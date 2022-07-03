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

namespace Avokado
{
    public partial class payment : Form
    {
        SqlCommand query = null;

        public payment()
        {
            InitializeComponent();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            if (ShoppingCart.checkDelivery)
            {
                priceL.Text = $"400";
            }
            else
            {
                priceL.Text = "0";
            }

            monthNUD.Value = Convert.ToInt32(DateTime.Now.Month);
            yearNUD.Value = Convert.ToInt32($"{DateTime.Now.ToString("yy")}");

            query = new SqlCommand($"select sum(price * amount) from storage s join shoppingCart sc on s.id_good = sc.id_good where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
            priceL.Text = (Convert.ToInt32(priceL.Text) + Convert.ToInt32(query.ExecuteScalar())).ToString();

            query = new SqlCommand($"select telephone from buyers where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
            telephoneMTB.Text = query.ExecuteScalar().ToString();
        }

        bool usePromo = false;

        private void button3_Click(object sender, EventArgs e)
        {
            query = new SqlCommand($"select count(*) from promocodes where promo like '{promoTB.Text}'", DBHElper.sqlConnection);
            if (query.ExecuteScalar().ToString().Equals("1") && !usePromo)
            {
                MessageBox.Show("Такой промокод существует!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                query = new SqlCommand($"select discount from promocodes where promo like '{promoTB.Text}'", DBHElper.sqlConnection);
                int percent = (Convert.ToInt32(priceL.Text) / 100) * Convert.ToInt32(query.ExecuteScalar());
                priceL.Text = (Convert.ToInt32(priceL.Text) - percent).ToString();
                usePromo = true;
            }
            else
            {
                MessageBox.Show("Такого промокода не существует!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Вы уверены что хотите отменить покупку?", "Подтвержедние", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show($"Подтвердите оплату", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (cvvMTB.MaskCompleted && numberMTB.MaskCompleted)
                {
                    query = new SqlCommand($"select numberCard from buyers where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
                    if (String.IsNullOrEmpty(query.ExecuteScalar().ToString()))
                    {
                        query = new SqlCommand($"update buyers set numberCard = @numberCard, cvvCode = @cvvCode, monthTerm = @monthTerm, yearTerm = @yearTerm where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);

                        query.Parameters.AddWithValue("numberCard", numberMTB.Text);
                        query.Parameters.AddWithValue("cvvCode", cvvMTB.Text);
                        query.Parameters.AddWithValue("monthTerm", monthNUD.Value);
                        query.Parameters.AddWithValue("yearTerm", yearNUD.Value);

                        query.ExecuteNonQuery();

                        buyCart();

                        MessageBox.Show("Платежные данные обновлены\nОплата прошла успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        query = new SqlCommand($"select count(*) from buyers where numberCard like '{numberMTB.Text}' and cvvCode like '{cvvMTB.Text}' and monthTerm like '{monthNUD.Value}' and yearTerm like '{yearNUD.Value}'", DBHElper.sqlConnection);
                        if (query.ExecuteScalar().ToString().Equals("1"))
                        {
                            buyCart();
                            MessageBox.Show("Оплата прошла успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            res = MessageBox.Show($"Вы используете новые платежные данные\nХотите ли обновить их?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (res == DialogResult.Yes)
                            {
                                query = new SqlCommand($"update buyers set numberCard = @numberCard, cvvCode = @cvvCode, monthTerm = @monthTerm, yearTerm = @yearTerm where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);

                                query.Parameters.AddWithValue("numberCard", numberMTB.Text);
                                query.Parameters.AddWithValue("cvvCode", cvvMTB.Text);
                                query.Parameters.AddWithValue("monthTerm", monthNUD.Value);
                                query.Parameters.AddWithValue("yearTerm", yearNUD.Value);

                                query.ExecuteNonQuery();

                                buyCart();
                                MessageBox.Show("Оплата прошла успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Укажите актуальные платежные данные", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля для оплаты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buyCart()
        {
            DateTime date1 = DateTime.Now;

            query = new SqlCommand("insert into orderHistories (summa, order_date, id_buyer, secAdd, minAdd) values (@summa, @order_date, @id_buyer, @secAdd, @minAdd)", DBHElper.sqlConnection);
            query.Parameters.AddWithValue("summa", priceL.Text);
            query.Parameters.AddWithValue("order_date", $"{date1.Day}.{date1.Month}.{date1.Year}");
            query.Parameters.AddWithValue("id_buyer", authForm.userId);
            query.Parameters.AddWithValue("secAdd", $"{date1.Second}");
            query.Parameters.AddWithValue("minAdd", $"{date1.Minute}");

            query.ExecuteNonQuery();

            query = new SqlCommand($"select [id_orderHistory] from [orderHistories] where [order_date] = '{date1.Day}.{date1.Month}.{date1.Year}' and [summa] like '{priceL.Text}' and [id_buyer] like '{authForm.userId}' and secAdd like '{date1.Second}' and minAdd like '{date1.Minute}'", DBHElper.sqlConnection);
            string kodOrder = query.ExecuteScalar().ToString();

            int[] id_good = new int[0];
            int[] amount = new int[0];
            int[] price = new int[0];
            int[] id_cart = new int[0];

            query = new SqlCommand($"select sc.id_good, amount, price, id_cart from shoppingCart sc join storage s on s.id_good = sc.id_good where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
            SqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                Array.Resize(ref id_good, id_good.Length + 1);
                Array.Resize(ref amount, amount.Length + 1);
                Array.Resize(ref price, price.Length + 1);
                Array.Resize(ref id_cart, id_cart.Length + 1);
                id_good[id_good.Length - 1] = reader.GetInt32(0);
                amount[amount.Length - 1] = reader.GetInt32(1);
                price[price.Length - 1] = reader.GetInt32(2);
                id_cart[id_cart.Length - 1] = reader.GetInt32(3);
            }
            reader.Close();

            for (int i = 0; i < id_good.Length; i++)
            {
                query = new SqlCommand($"insert into orderComp (id_orderHistory, id_good, amountPerItem, price) values (@id_orderHistory, @id_good, @amountPerItem, @price)", DBHElper.sqlConnection);

                query.Parameters.AddWithValue("id_orderHistory", kodOrder);
                query.Parameters.AddWithValue("id_good", id_good[i]);
                query.Parameters.AddWithValue("amountPerItem", amount[i]);
                query.Parameters.AddWithValue("price", price[i]);

                query.ExecuteNonQuery();
            }

            for (int i = 0; i < id_cart.Length; i++)
            {
                query = new SqlCommand($"delete from shoppingCart where id_cart like '{id_cart[i]}'", DBHElper.sqlConnection);
                query.ExecuteNonQuery();
            }
        }
    }
}
