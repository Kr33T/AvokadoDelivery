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
    public partial class listOfOrder : Form
    {
        SqlCommand query = null;
        SqlDataAdapter dataAdapter = null;
        DataSet dataSet = null;

        public listOfOrder()
        {
            InitializeComponent();
        }

        private void listOfOrder_Load(object sender, EventArgs e)
        {
            try
            {
                dataAdapter = new SqlDataAdapter($"select brand_name, good_name, amountPerItem, price from brands b join goods g on g.id_brand = b.ID_brand join orderComp oc on oc.id_good = g.id_good join orderHistories oh on oh.id_orderHistory = oc.id_orderHistory where oh.id_buyer like '{authForm.userId}' and oc.id_orderHistory like '{userData.row}'", DBHElper.sqlConnection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                listOfOrderDGV.DataSource = dataSet.Tables[0];

                query = new SqlCommand($"select summa from orderHistories where id_orderHistory like '{userData.row}'", DBHElper.sqlConnection);
                totalPriceL.Text = query.ExecuteScalar().ToString();
            }
            catch
            {
                MessageBox.Show($"Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {
                MessageBox.Show($"Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
