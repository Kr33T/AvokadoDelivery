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
    public partial class userData : Form
    {
        SqlCommand query = null;
        SqlDataReader reader = null;

        public userData()
        {
            InitializeComponent();
        }

        private void userData_Load(object sender, EventArgs e)
        {
            query = new SqlCommand($"select gender_name from genders", DBHElper.sqlConnection);
            reader = query.ExecuteReader();
            while (reader.Read())
            {
                genderCB.Items.Add(reader.GetString(0));
            }
            reader.Close();

            query = new SqlCommand($"select (surname + ' ' + [name] + ' ' + midname), telephone, email, gender_name from buyers b join genders g on g.id_gender = b.id_gender where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
            reader = query.ExecuteReader();
            reader.Read();
            fioTB.Text = reader.GetString(0);
            telephoneMTB.Text = reader.GetString(1);
            emailTB.Text = reader.GetString(2);
            genderCB.SelectedItem = reader.GetString(3);
            reader.Close();
            query = new SqlCommand($"select useDelivery from buyers where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
            useDeliveryCB.Checked = Convert.ToBoolean(query.ExecuteScalar());
            if (useDeliveryCB.Checked)
            {
                SqlCommand a = new SqlCommand($"select id_address from buyers where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
                int id = Convert.ToInt32(a.ExecuteScalar());
                a = new SqlCommand($"select region + ', ' + district + ', ' + locality + ', ' + street + ', ' + house from addresses where id_address like '{id}'", DBHElper.sqlConnection);
                addressL.Text = a.ExecuteScalar().ToString();
                addressL.Visible = true;
                changeAddressBTN.Visible = true;
            }
            else
            {
                addressL.Visible = false;
                changeAddressBTN.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (useDeliveryCB.Checked)
            {
                SqlCommand a = new SqlCommand($"select id_address from buyers where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
                if (String.IsNullOrEmpty(a.ExecuteScalar().ToString()))
                {
                    useDeliveryCB.Checked = false;
                    var res = MessageBox.Show($"Вы не еще ни разу не указывали адрес\nХотите ввести новый?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        changeAddress change = new changeAddress();
                        change.Show();
                        useDeliveryCB.Checked = false;
                    }
                    else
                    {
                        useDeliveryCB.Checked = false;
                    }
                }
                else
                {
                    SqlCommand b = new SqlCommand($"select id_address from buyers where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
                    a = new SqlCommand($"select region + ', ' + district + ', ' + locality + ', ' + street + ', ' + house from addresses where id_address like '{b.ExecuteScalar()}'", DBHElper.sqlConnection);
                    addressL.Text = a.ExecuteScalar().ToString();
                    addressL.Visible = true;
                    changeAddressBTN.Visible = true;
                }
            }
            else
            {
                addressL.Visible = false;
                changeAddressBTN.Visible = false;
            }
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            string[] str = fioTB.Text.Trim().Split(' ');

            if(str.Length == 3)
            {
                query = new SqlCommand($"update buyers set surname = @surname, [name] = @name, midname = @midname, id_gender = @id_gender, telephone = @telephone, email = @email, useDelivery = @useDelivery where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
                query.Parameters.AddWithValue("surname", str[0]);
                query.Parameters.AddWithValue("name", str[1]);
                query.Parameters.AddWithValue("midname", str[2]);
                SqlCommand a = new SqlCommand($"select id_gender from genders where gender_name like '{genderCB.SelectedItem}'", DBHElper.sqlConnection);
                query.Parameters.AddWithValue("id_gender", a.ExecuteScalar());
                query.Parameters.AddWithValue("telephone", telephoneMTB.Text);
                if (atCheck)
                {
                    query.Parameters.AddWithValue("email", emailTB.Text + endingEmailCB.SelectedItem);
                }
                else
                {
                    query.Parameters.AddWithValue("email", emailTB.Text);
                }
                query.Parameters.AddWithValue("useDelivery", useDeliveryCB.Checked);
                var res = MessageBox.Show("Уверены, что хотите изменить данные?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (query.ExecuteNonQuery().ToString().Equals("1"))
                    {
                        MessageBox.Show("Данные изменены успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Некорректно введено ФИО, перепровеьте данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Уверены, что хотите отменить действие?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Действие отменено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        bool atCheck = true;

        private void emailTB_TextChanged(object sender, EventArgs e)
        {
            if (emailTB.Text.Contains('@'))
            {
                endingEmailCB.Visible = false;
                emailTB.Size = new Size(208, 20);
                atCheck = false;
            }
            else
            {
                endingEmailCB.Visible = true;
                emailTB.Size = new Size(128, 20);
                atCheck = true;
            }
        }

        private void changeAuthDataBTN_Click(object sender, EventArgs e)
        {
            changeAuthData changeAuth = new changeAuthData();
            changeAuth.Show();
        }

        private void changeAddressBTN_Click(object sender, EventArgs e)
        {
            changeAddress changeAdd = new changeAddress();
            changeAdd.Show();

            changeAdd.FormClosing += (obj, args) =>
            {
                useDeliveryCB.Checked = false;
            };
        }
    }
}
