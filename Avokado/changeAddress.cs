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
    public partial class changeAddress : Form
    {
        SqlCommand query = null;

        public changeAddress()
        {
            InitializeComponent();
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Вы уверены, что хотите отменить действие?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void changeAddress_Load(object sender, EventArgs e)
        {
            
        }

        private void changeAddressBTN_Click(object sender, EventArgs e)
        {
            query = new SqlCommand($"select id_address from buyers where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
            if (String.IsNullOrEmpty(query.ExecuteScalar().ToString()))
            {
                query = new SqlCommand($"insert into addresses ([index], country, region, district, locality, street, house) values (@index, @country, @region, @district, @locality, @street, @house)", DBHElper.sqlConnection);
                
                query.Parameters.AddWithValue("index", indexMTB.Text);
                query.Parameters.AddWithValue("country", "Россия");
                query.Parameters.AddWithValue("region", regionTB.Text);
                query.Parameters.AddWithValue("district", districtTB.Text);
                query.Parameters.AddWithValue("locality", localityTB.Text);
                query.Parameters.AddWithValue("street", streetTB.Text);
                query.Parameters.AddWithValue("house", houseTB.Text);

                query.ExecuteNonQuery();

                query = new SqlCommand($"update buyers set id_address = (select id_address from addresses where [index] like @index and country like @country and region like @region and district like @district and locality = @locality and street like @street and house like @house) where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);

                query.Parameters.AddWithValue("index", indexMTB.Text);
                query.Parameters.AddWithValue("country", "Россия");
                query.Parameters.AddWithValue("region", regionTB.Text);
                query.Parameters.AddWithValue("district", districtTB.Text);
                query.Parameters.AddWithValue("locality", localityTB.Text);
                query.Parameters.AddWithValue("street", streetTB.Text);
                query.Parameters.AddWithValue("house", houseTB.Text);

                if (query.ExecuteNonQuery().ToString().Equals("1"))
                {
                    MessageBox.Show("Добавление прошло успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                query = new SqlCommand($"update addresses set [index] = @index, country = @country, region = @region, district = @district, locality = @locality, street = @street, house = @house where id_address like (select id_address from buyers where id_buyer like '{authForm.userId}')", DBHElper.sqlConnection);
                
                query.Parameters.AddWithValue("index", indexMTB.Text);
                query.Parameters.AddWithValue("country", "Россия");
                query.Parameters.AddWithValue("region", regionTB.Text);
                query.Parameters.AddWithValue("district", districtTB.Text);
                query.Parameters.AddWithValue("locality", localityTB.Text);
                query.Parameters.AddWithValue("street", streetTB.Text);
                query.Parameters.AddWithValue("house", houseTB.Text);
                
                if (query.ExecuteNonQuery().ToString().Equals("1"))
                {
                    MessageBox.Show("Изменение прошло успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
