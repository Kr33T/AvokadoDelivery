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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            profileL.Text = "Здравствуйте, " + authForm.userName + "!";

            SqlDataAdapter dataAdapter = new SqlDataAdapter($"select goods.id_good as '№', brand_name as 'Брэнд', good_name as 'Название продукта', goodType_name as 'Категория', price as 'Стоимость за ед.' from goods join brands on brands.id_brand = goods.id_brand join goodTypes on goodTypes.id_goodType = goods.id_goodType join storage on storage.id_good = goods.id_good", DBHElper.sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            goodsDGV.DataSource = dataSet.Tables[0];
            goodsDGV.AutoSizeColumnsMode.Equals(DataGridViewAutoSizeColumnsMode.AllCells);

            SqlCommand a = new SqlCommand($"select brand_name from brands", DBHElper.sqlConnection);
            SqlDataReader reader = a.ExecuteReader();
            while (reader.Read())
            {
                brandCB.Items.Add(reader.GetString(0));
            }
            reader.Close();

            a = new SqlCommand($"select goodType_name from goodTypes", DBHElper.sqlConnection);
            reader = a.ExecuteReader();
            while (reader.Read())
            {
                goodTypeCB.Items.Add(reader.GetString(0));
            }
            reader.Close();

            a = new SqlCommand($"select min(price) from storage", DBHElper.sqlConnection);
            SqlCommand b = new SqlCommand($"select max(price) from storage", DBHElper.sqlConnection);
            minPriceNUD.Minimum = Convert.ToInt32(a.ExecuteScalar());
            minPriceNUD.Maximum = Convert.ToInt32(b.ExecuteScalar());
            maxPriceNUD.Minimum = Convert.ToInt32(a.ExecuteScalar());
            maxPriceNUD.Maximum = Convert.ToInt32(b.ExecuteScalar());

            minPriceNUD.Value = minPriceNUD.Minimum;
            maxPriceNUD.Value = maxPriceNUD.Maximum;
        }

        private void profileL_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(profileL.Size.Width - profileL.Size.Height, profileL.Size.Height);
            panel1.BringToFront();
            panel1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            authForm.userName = "";
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortGoodsDGV();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sortGoodsDGV();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortGoodsDGV();
        }

        private void sortGoodsDGV()
        {
            (goodsDGV.DataSource as DataTable).DefaultView.RowFilter = $"[Название продукта] like '%{nameGoodTB.Text}%' and [Брэнд] like '%{brandCB.SelectedItem}%' and [Категория] like '%{goodTypeCB.SelectedItem}%' and [Стоимость за ед.] >= '{minPriceNUD.Value}' and [Стоимость за ед.] <= '{maxPriceNUD.Value}'";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            sortGoodsDGV();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            sortGoodsDGV();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test a = new test();
            a.Show();
        }
    }
}
