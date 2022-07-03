using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Avokado
{
    public partial class ShoppingCart : Form
    {
        SqlCommand query = null;
        SqlDataReader reader = null;

        public ShoppingCart()
        {
            InitializeComponent();
        }

        int[] am = new int[0];
        Panel[] panels = new Panel[0];
        PictureBox[] pics = new PictureBox[0];
        Label[] names = new Label[0];
        Label[] prices = new Label[0];
        Button[] del = new Button[0];
        int[] index = new int[0];
        int[] indInCart = new int[0];

        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            changeAddressBTN.Visible = false;
            updateCart();
        }

        void updateCart()
        {
            goodsP.Controls.Clear();

            query = new SqlCommand($"select sc.id_good, [image], good_name, [price] * [amount], [amount], sc.id_cart from shoppingCart sc join goods g on g.id_good = sc.id_good join storage s on s.id_good = sc.id_good where [amount] > 0 and sc.id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
            reader = query.ExecuteReader();
            int i = 0, y = 0;
            while (reader.Read())
            {
                Array.Resize(ref am, am.Length + 1);
                Array.Resize(ref indInCart, indInCart.Length + 1);
                am[i] = reader.GetInt32(4);
                indInCart[i] = reader.GetInt32(5);
                Array.Resize(ref panels, panels.Length + 1);
                Array.Resize(ref pics, pics.Length + 1);
                Array.Resize(ref names, names.Length + 1);
                Array.Resize(ref prices, prices.Length + 1);
                Array.Resize(ref del, del.Length + 1);
                Array.Resize(ref index, index.Length + 1);
                index[i] = reader.GetInt32(0);
                panels[i] = new Panel() { Location = new Point(0, y), Size = new Size(goodsP.Width - 17, 130), BorderStyle = BorderStyle.FixedSingle, Tag = index[i] };
                goodsP.Controls.Add(panels[i]);
                FileStream fsBLOBFile = new FileStream(reader.GetString(1).ToString(), FileMode.Open, FileAccess.Read);
                panels[i].Controls.Add(pics[i] = new PictureBox() { Location = new Point(0, 0), Size = new Size(panels[i].Height, panels[i].Height), SizeMode = PictureBoxSizeMode.Zoom, Image = Image.FromStream(fsBLOBFile), Tag = i });
                panels[i].Controls.Add(names[i] = new Label() { Text = reader.GetString(2).ToString() + " (" + reader.GetInt32(4).ToString() + ")", Location = new Point(pics[i].Width + 10, 58), Tag = i });
                panels[i].Controls.Add(prices[i] = new Label() { Text = reader.GetInt32(3).ToString(), Location = new Point(panels[i].Width - 150, 58), Tag = i, TextAlign = ContentAlignment.TopRight });
                panels[i].Controls.Add(del[i] = new Button() { Text = "X", Location = new Point(panels[i].Width - 30, 0), Size = new Size(30, panels[i].Height - 2), Tag = i });
                del[i].Click += (obj, args) =>
                {
                    query = new SqlCommand($"update storage set quantity = quantity + {am[Convert.ToInt32((obj as Button).Tag)]} where id_good like '{index[Convert.ToInt32((obj as Button).Tag)]}'", DBHElper.sqlConnection);
                    query.ExecuteNonQuery();
                    query = new SqlCommand($"delete from shoppingCart where id_cart like '{indInCart[Convert.ToInt32((obj as Button).Tag)]}'", DBHElper.sqlConnection);
                    query.ExecuteNonQuery();
                    updateCart();
                };
                y += panels[i].Height + 10;
                i++;
            }
            reader.Close();
            query = new SqlCommand($"select count(*) from shoppingCart where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
            if (query.ExecuteScalar().ToString().Equals("0"))
            {
                priceL.Text = "0";
            }
            else
            {
                query = new SqlCommand($"select sum(price * amount) from shoppingCart sc join storage s on s.id_good = sc.id_good where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
                priceL.Text = query.ExecuteScalar().ToString();
            }
            query = new SqlCommand($"select count(*) from shoppingCart where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
            if (query.ExecuteScalar().ToString().Equals("0"))
            {
                countGoodsL.Text = $"Продуктов: {query.ExecuteScalar()}";
                priceCountL.Text = "0";
            }
            else
            {
                countGoodsL.Text = $"Продуктов: {query.ExecuteScalar()}";
                query = new SqlCommand($"select sum(price * amount) from shoppingCart sc join storage s on sc.id_good = s.id_good where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
                priceCountL.Text = query.ExecuteScalar().ToString();
            }
        }

        int[] indForDel = new int[0];
        int[] amountForDel = new int[0];
        int[] indSC = new int[0];

        private void button1_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Уверены, что хотите очистить корзину?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                query = new SqlCommand($"select id_cart, id_good, amount from shoppingCart where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    Array.Resize(ref indForDel, indForDel.Length + 1);
                    Array.Resize(ref amountForDel, amountForDel.Length + 1);
                    Array.Resize(ref indSC, indSC.Length + 1);
                    indSC[indSC.Length - 1] = reader.GetInt32(0);
                    indForDel[indForDel.Length - 1] = reader.GetInt32(1);
                    amountForDel[amountForDel.Length - 1] = reader.GetInt32(2);
                }
                reader.Close();
                for (int i = 0; i < indForDel.Length; i++)
                {
                    query = new SqlCommand($"update storage set quantity = quantity + {amountForDel[i]} where id_good like '{indForDel[i]}'", DBHElper.sqlConnection);
                    query.ExecuteNonQuery();
                    query = new SqlCommand($"delete from shoppingCart where id_cart like '{indSC[i]}'", DBHElper.sqlConnection);
                    query.ExecuteNonQuery();
                }
                updateCart();
            }
            else
            {
                MessageBox.Show("Действие отменено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static public bool checkDelivery = false;

        private void buyBTN_Click(object sender, EventArgs e)
        {
            query = new SqlCommand($"select count(*) from shoppingcart where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
            if (!query.ExecuteScalar().ToString().Equals("0"))
            {
                payment payment = new payment();
                payment.Show();

                payment.FormClosing += (obj, args) =>
                {
                    updateCart();
                };
            }
            else
            {
                MessageBox.Show("Ваша корзина пуста!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (deliveryCB.Checked)
            {
                checkDelivery = true;
                SqlCommand a = new SqlCommand($"select id_address from buyers where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
                if (String.IsNullOrEmpty(a.ExecuteScalar().ToString()))
                {
                    deliveryCB.Checked = checkDelivery = false;
                    var res = MessageBox.Show($"Вы не еще ни разу не указывали адрес\nХотите ввести новый?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        changeAddress change = new changeAddress();
                        change.Show();
                        deliveryCB.Checked = checkDelivery = false;
                    }
                    else
                    {
                        deliveryCB.Checked = checkDelivery = false;
                    }
                }
                else
                {
                    SqlCommand b = new SqlCommand($"select id_address from buyers where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
                    a = new SqlCommand($"select region + ', ' + district + ', ' + locality + ', ' + street + ', ' + house from addresses where id_address like '{b.ExecuteScalar()}'", DBHElper.sqlConnection);
                    addressL.Text = a.ExecuteScalar().ToString();
                    addressL.Visible = true;
                    changeAddressBTN.Visible = true;
                    priceL.Text = (Convert.ToInt32(priceL.Text) + 400).ToString();
                    deliveryPriceL.Text = $"400";
                }
            }
            else
            {
                checkDelivery = false;
                deliveryPriceL.Text = $"0";
                priceL.Text = (Convert.ToInt32(priceL.Text) - 400).ToString();
                addressL.Visible = false;
                changeAddressBTN.Visible = false;
            }
        }

        private void changeAddressBTN_Click(object sender, EventArgs e)
        {
            changeAddress change = new changeAddress();
            change.Show();

            change.FormClosing += (obj, args) =>
            {
                deliveryCB.Checked = checkDelivery = false;
                deliveryCB.Checked = checkDelivery = true;
            };
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
