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
using System.Drawing.Imaging;

namespace Avokado
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        SqlCommand query = null;
        SqlDataReader reader = null;

        private void test_Load(object sender, EventArgs e)
        {
            updatePanelOfGoods();

            SqlCommand a = new SqlCommand($"select min(price) from storage", DBHElper.sqlConnection);
            SqlCommand b = new SqlCommand($"select max(price) from storage", DBHElper.sqlConnection);
            minPriceNUD.Minimum = Convert.ToInt32(a.ExecuteScalar());
            minPriceNUD.Maximum = Convert.ToInt32(b.ExecuteScalar());
            maxPriceNUD.Minimum = Convert.ToInt32(a.ExecuteScalar());
            maxPriceNUD.Maximum = Convert.ToInt32(b.ExecuteScalar());

            minPriceNUD.Value = minPriceNUD.Minimum;
            maxPriceNUD.Value = maxPriceNUD.Maximum;

            CheckBox[] checkBoxesCat = new CheckBox[0];
            query = new SqlCommand($"select goodType_name, id_goodtype from goodTypes", DBHElper.sqlConnection);
            reader = query.ExecuteReader();
            int i = 0, x = 3, y = 3;
            while (reader.Read())
            {
                Array.Resize(ref checkBoxesCat, checkBoxesCat.Length + 1);
                checkBoxesCat[i] = new CheckBox() { Text = reader.GetString(0), Tag = reader.GetInt32(1), Location = new Point(x, y), Size = new Size(190, 20) };
                checkBoxesCat[i].CheckedChanged += (obj, args) =>
                {
                    updatePanelOfGoods();
                };
                categoriesP.Controls.Add(checkBoxesCat[i]);
                y += 19;
                i++;
            }
            reader.Close();

            x = y = 0;
            CheckBox[] checkBoxesBrnd = new CheckBox[0];
            query = new SqlCommand($"select brand_name, id_brand from brands", DBHElper.sqlConnection);
            reader = query.ExecuteReader();
            i = 0;
            while (reader.Read())
            {
                Array.Resize(ref checkBoxesBrnd, checkBoxesBrnd.Length + 1);
                checkBoxesBrnd[i] = new CheckBox() { Text = reader.GetString(0), Tag = reader.GetInt32(1), Location = new Point(x, y), Size = new Size(190, 20) };
                checkBoxesBrnd[i].CheckedChanged += (obj, args) =>
                {
                    updatePanelOfGoods();
                };
                brandsP.Controls.Add(checkBoxesBrnd[i]);
                y += 19;
                i++;
            }
            reader.Close();
        }

        string[] sortArr1 = new string[0];
        string[] sortArr2 = new string[0];
        string sort = null;
        string temp = null;

        Panel[] panels = new Panel[0];
        PictureBox[] pic = new PictureBox[0];
        Label[] name = new Label[0];
        Label[] price = new Label[0];
        Button[] add = new Button[0];
        NumericUpDown[] amount = new NumericUpDown[0];
        string[] index = new string[0];
        int x, y, ind;

        void updatePanelOfGoods()
        {
            productsP.Controls.Clear();
            Array.Resize(ref sortArr1, 0);
            Array.Resize(ref sortArr2, 0);
            sort = null;
            

            foreach (CheckBox checkBox in categoriesP.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    Array.Resize(ref sortArr1, sortArr1.Length + 1);
                    sortArr1[sortArr1.Length - 1] = $"'{checkBox.Tag}'";
                }
            }

            foreach(CheckBox checkBox in brandsP.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    Array.Resize(ref sortArr2, sortArr2.Length + 1);
                    sortArr2[sortArr2.Length - 1] = $"'{checkBox.Tag}'";
                }
            }

            if (sortArr1.Length != 0)
            {
                sort = String.Join(", ", sortArr1);
                sort = " and id_goodtype in (" + sort + ")";
            }

            if(sortArr2.Length != 0)
            {
                temp = String.Join(", ", sortArr2);
                sort += " and id_brand in (" + temp + ")"; 
            }

            if (!String.IsNullOrEmpty(searchTB.Text))
            {
                sort += $"and good_name like '%{searchTB.Text}%'";
            }

            Array.Resize(ref panels, 0);
            Array.Resize(ref pic, 0);
            Array.Resize(ref name, 0);
            Array.Resize(ref price, 0);
            Array.Resize(ref add, 0);
            Array.Resize(ref amount, 0);
            Array.Resize(ref index, 0);

            int i = 0;

            SqlCommand a = new SqlCommand($"select g.id_good from goods g join storage s on s.id_good = g.id_good where s.price >= '{minPriceNUD.Value}' and s.price <= '{maxPriceNUD.Value}' and quantity > 0{sort}", DBHElper.sqlConnection);
            SqlDataReader reader = a.ExecuteReader();
            while (reader.Read())
            {
                Array.Resize(ref panels, panels.Length + 1);
                Array.Resize(ref pic, pic.Length + 1);
                Array.Resize(ref name, name.Length + 1);
                Array.Resize(ref price, price.Length + 1);
                Array.Resize(ref add, add.Length + 1);
                Array.Resize(ref amount, amount.Length + 1);
                Array.Resize(ref index, index.Length + 1);
                index[i] = reader.GetInt32(0).ToString();
                i++;
            }
            reader.Close();

            x = 0;
            y = 0;
            ind = 1;
            for (i = 0; i < panels.Length; i++)
            {
                panels[i] = new Panel()
                {
                    Location = new Point(x, y),
                    Size = new Size(323, 400),
                    BorderStyle = BorderStyle.FixedSingle
                };
                productsP.Controls.Add(panels[i]);
                query = new SqlCommand($"select image, good_name, price, quantity from goods g join storage s on s.id_good = g.ID_good where g.id_good like '{index[i]}'", DBHElper.sqlConnection);
                reader = query.ExecuteReader();
                reader.Read();
                FileStream fsBLOBFile = new FileStream(reader.GetString(0).ToString(), FileMode.Open, FileAccess.Read);
                panels[i].Controls.Add(pic[i] = new PictureBox() { Size = new Size(panels[i].Width, 300), Location = new Point(0, 0), Image = Image.FromStream(fsBLOBFile), SizeMode = PictureBoxSizeMode.Zoom });
                panels[i].Controls.Add(name[i] = new Label() { Text = $"{reader.GetString(1)}", Location = new Point(0, pic[i].Height + 20) });
                panels[i].Controls.Add(price[i] = new Label() { Text = $"{reader.GetInt32(2)}", Location = new Point(panels[i].Size.Width - 100, pic[i].Height + 20), TextAlign = ContentAlignment.TopRight });
                panels[i].Controls.Add(add[i] = new Button() { Text = $"Добавить в корзину товар", Location = new Point(0, price[i].Location.Y + price[i].Size.Height), Size = new Size(panels[i].Width - 100, 22), Tag = i });
                panels[i].Controls.Add(amount[i] = new NumericUpDown() { Location = new Point(add[i].Width + 10, add[i].Location.Y), Size = new Size(80, 20), Tag = i, Minimum = 1, Maximum = reader.GetInt32(3)});
                reader.Close();
                add[i].Click += (obj, args) =>
                {
                    query = new SqlCommand($"select count(*) from shoppingCart where id_buyer like '{authForm.userId}' and id_good like '{index[Convert.ToInt32((obj as Button).Tag)]}'", DBHElper.sqlConnection);
                    if (query.ExecuteScalar().ToString().Equals("1"))
                    {
                        query = new SqlCommand($"update shoppingCart set amount = amount + {amount[Convert.ToInt32((obj as Button).Tag)].Value} where id_good like '{index[Convert.ToInt32((obj as Button).Tag)]}' and id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
                        query.ExecuteNonQuery();
                    }
                    else
                    {
                        query = new SqlCommand($"insert into shoppingCart (id_buyer, id_good, amount) values ('{authForm.userId}', '{index[Convert.ToInt32((obj as Button).Tag)]}', '{amount[Convert.ToInt32((obj as Button).Tag)].Value}')", DBHElper.sqlConnection);
                        query.ExecuteNonQuery();
                    }
                    query = new SqlCommand($"update storage set quantity = quantity - {amount[Convert.ToInt32((obj as Button).Tag)].Value} where id_good like '{index[Convert.ToInt32((obj as Button).Tag)]}'", DBHElper.sqlConnection);
                    query.ExecuteNonQuery();
                    amount[Convert.ToInt32((obj as Button).Tag)].Value = amount[Convert.ToInt32((obj as Button).Tag)].Minimum;
                    query = new SqlCommand($"select quantity from storage where id_good like '{index[Convert.ToInt32((obj as Button).Tag)]}'", DBHElper.sqlConnection);
                    amount[Convert.ToInt32((obj as Button).Tag)].Maximum = (int)query.ExecuteScalar();
                    query = new SqlCommand($"select quantity from storage where id_good like '{index[Convert.ToInt32((obj as Button).Tag)]}'", DBHElper.sqlConnection);
                    if (query.ExecuteScalar().ToString().Equals("0"))
                    {
                        updatePanelOfGoods();
                    }
                };
                if (ind == 3)
                {
                    x = 0;
                    y = panels[i].Location.Y + 410;
                    ind = 1;
                }
                else
                {
                    x = panels[i].Location.X + 10 + panels[i].Size.Width;
                    y = panels[i].Location.Y;
                    ind++;
                }
            }
        }

        private void minPriceNUD_ValueChanged(object sender, EventArgs e)
        {
            updatePanelOfGoods();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(CheckBox checkBox in categoriesP.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = false;
            }

            foreach (CheckBox checkBox in brandsP.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = false;
            }

            minPriceNUD.Value = minPriceNUD.Minimum;
            maxPriceNUD.Value = maxPriceNUD.Maximum;
        }

        bool checkShowActions = true;

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkShowActions)
            {
                actionsP.Visible = true;
                actionsP.Location = new Point(980, 79);
                checkShowActions = !checkShowActions;
            }
            else
            {
                actionsP.Visible = false;
                checkShowActions = !checkShowActions;
            }
        }

        private void closePanel_Click(object sender, EventArgs e)
        {
            checkShowActions = !checkShowActions;
            actionsP.Visible = false;
        }

        private void logOutBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userDataBTN_Click(object sender, EventArgs e)
        {
            userData user = new userData();
            user.Show();
        }

        private void orderHistoryBTN_Click(object sender, EventArgs e)
        {
            orderHistory order = new orderHistory();
            order.Show();
        }

        private void cartBTN_Click(object sender, EventArgs e)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Show();

            cart.FormClosing += (obj, args) =>
            {
                updatePanelOfGoods();
            };
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            updatePanelOfGoods();
        }

        private void maxPriceNUD_ValueChanged(object sender, EventArgs e)
        {
            updatePanelOfGoods();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            updatePanelOfGoods();
        }
    }
}
