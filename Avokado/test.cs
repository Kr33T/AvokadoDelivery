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

            CheckBox[] checkBoxes = new CheckBox[0];
            query = new SqlCommand($"select goodType_name from goodTypes", DBHElper.sqlConnection);
            SqlDataReader reader = query.ExecuteReader();
            int i = 0, x = 3, y = 3;
            while (reader.Read())
            {
                Array.Resize(ref checkBoxes, checkBoxes.Length + 1);
                checkBoxes[i] = new CheckBox() { Text = reader.GetString(0), Tag = i, Location = new Point(x, y) };
                checkBoxes[i].CheckedChanged += (obj, args) =>
                {
                    updatePanelOfGoods();
                };
                categoriesP.Controls.Add(checkBoxes[i]);
                y += 19;
                i++;
            }
            reader.Close();
        }

        string[] sortArr = new string[0];
        string sort = null;

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
            Array.Resize(ref sortArr, 0);
            sort = null;
            

            foreach (CheckBox checkBox in categoriesP.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    Array.Resize(ref sortArr, sortArr.Length + 1);
                    query = new SqlCommand($"select id_goodtype from goodtypes where goodType_name like '{checkBox.Text}'", DBHElper.sqlConnection);
                    sortArr[sortArr.Length - 1] = $"id_goodType like '{query.ExecuteScalar()}'";
                }
            }

            if (!String.IsNullOrEmpty(searchTB.Text))
            {
                Array.Resize(ref sortArr, sortArr.Length + 1);
                sortArr[sortArr.Length - 1] = $"good_name like '%{searchTB.Text}%'";
            }
            
            if (sortArr.Length != 0)
            {
                sort = String.Join(" and ", sortArr);
                sort = " and " + sort;
            }

            Array.Resize(ref panels, 0);
            Array.Resize(ref pic, 0);
            Array.Resize(ref name, 0);
            Array.Resize(ref price, 0);
            Array.Resize(ref add, 0);
            Array.Resize(ref amount, 0);
            Array.Resize(ref index, 0);

            int i = 0;

            SqlCommand a = new SqlCommand($"select g.id_good from goods g join storage s on s.id_good = g.id_good where s.price >= '{minPriceNUD.Value}' and s.price <= '{maxPriceNUD.Value}'{sort}", DBHElper.sqlConnection);
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
                panels[i].Controls.Add(pic[i] = new PictureBox() { BackColor = Color.Azure, Size = new Size(panels[i].Width, 300), Location = new Point(0, 0), Image = Image.FromStream(fsBLOBFile), SizeMode = PictureBoxSizeMode.Zoom });
                panels[i].Controls.Add(name[i] = new Label() { Text = $"{reader.GetString(1)}", Location = new Point(0, pic[i].Height + 20) });
                panels[i].Controls.Add(price[i] = new Label() { Text = $"{reader.GetInt32(2)}", Location = new Point(panels[i].Size.Width - 100, pic[i].Height + 20), TextAlign = ContentAlignment.TopRight });
                panels[i].Controls.Add(add[i] = new Button() { Text = $"Добавить в корзину товар", Location = new Point(0, price[i].Location.Y + price[i].Size.Height), Size = new Size(panels[i].Width - 100, 22), Tag = i });
                panels[i].Controls.Add(amount[i] = new NumericUpDown() { Location = new Point(add[i].Width + 10, add[i].Location.Y), Size = new Size(80, 20), Tag = i, Minimum = 1, Maximum = reader.GetInt32(3)});
                reader.Close();
                add[i].Click += (obj, args) =>
                {
                    query = new SqlCommand($"insert into shoppingCart (id_good, amount) values ('{index[Convert.ToInt32((obj as Button).Tag)]}', '{amount[Convert.ToInt32((obj as Button).Tag)].Value}')", DBHElper.sqlConnection);
                    query.ExecuteNonQuery();
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
