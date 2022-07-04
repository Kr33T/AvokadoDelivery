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
    public partial class registrationForm : Form
    {
        SqlCommand query = null;

        public registrationForm()
        {
            InitializeComponent();
        }

        private void regBTN_Click(object sender, EventArgs e)
        {
            try
            {
                query = new SqlCommand($"select count(*) from buyers where login like '{loginTB.Text}'", DBHElper.sqlConnection);
                if (!query.ExecuteScalar().ToString().Equals("1"))
                {
                    if (checkDeliveryCB.Checked)
                    {
                        SqlCommand a = new SqlCommand($"insert into addresses ([index], country, region, district, locality, street, house) values (@index, @country, @region, @district, @locality, @street, @house)", DBHElper.sqlConnection);
                        a.Parameters.AddWithValue("index", indexMTB.Text);
                        a.Parameters.AddWithValue("country", "Россия");
                        a.Parameters.AddWithValue("region", regionTB.Text);
                        a.Parameters.AddWithValue("district", districtTB.Text);
                        a.Parameters.AddWithValue("locality", localityTB.Text);
                        a.Parameters.AddWithValue("street", streetTB.Text);
                        a.Parameters.AddWithValue("house", houseTB.Text);
                        a.ExecuteNonQuery();
                        SqlCommand getAddressID = new SqlCommand($"select id_address from addresses where [index] like '{indexMTB.Text}' and country like 'Россия' and region like '{regionTB.Text}' and district like '{districtTB.Text}' and locality like '{localityTB.Text}' and street like '{streetTB.Text}' and house like '{houseTB.Text}'", DBHElper.sqlConnection);
                        a = new SqlCommand($"insert into buyers (surname, name, midname, id_gender, login, password, telephone, email, id_address, useDelivery) values (@surname, @name, @midname, @id_gender, @login, @password, @telephone, @email, @id_address, @useDelivery)", DBHElper.sqlConnection);
                        a.Parameters.AddWithValue("surname", surnameTB.Text);
                        a.Parameters.AddWithValue("name", nameTB.Text);
                        a.Parameters.AddWithValue("midname", midnameTB.Text);
                        SqlCommand getGenderID = new SqlCommand($"select id_gender from genders where gender_name like '{genderCB.SelectedItem}'", DBHElper.sqlConnection);
                        a.Parameters.AddWithValue("id_gender", getGenderID.ExecuteScalar().ToString());
                        a.Parameters.AddWithValue("login", loginTB.Text);
                        a.Parameters.AddWithValue("password", passwordTB.Text);
                        a.Parameters.AddWithValue("telephone", telephoneMTB.Text);
                        if (atCheck)
                        {
                            a.Parameters.AddWithValue("email", emailTB.Text + endingEmailCB.SelectedItem);
                        }
                        else
                        {
                            a.Parameters.AddWithValue("email", emailTB.Text);
                        }
                        a.Parameters.AddWithValue("id_address", getAddressID.ExecuteScalar().ToString());
                        a.Parameters.AddWithValue("useDelivery", checkDeliveryCB.CheckState);
                        if (a.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Добавление прошло успешно!");
                            this.Close();
                        }
                    }
                    else
                    {
                        SqlCommand a = new SqlCommand($"insert into buyers (surname, name, midname, id_gender, login, password, telephone, email, useDelivery) values (@surname, @name, @midname, @id_gender, @login, @password, @telephone, @email, @useDelivery)", DBHElper.sqlConnection);
                        a.Parameters.AddWithValue("surname", surnameTB.Text);
                        a.Parameters.AddWithValue("name", nameTB.Text);
                        a.Parameters.AddWithValue("midname", midnameTB.Text);
                        SqlCommand getGenderID = new SqlCommand($"select id_gender from genders where gender_name like '{genderCB.SelectedItem}'", DBHElper.sqlConnection);
                        a.Parameters.AddWithValue("id_gender", getGenderID.ExecuteScalar().ToString());
                        a.Parameters.AddWithValue("login", loginTB.Text);
                        a.Parameters.AddWithValue("password", passwordTB.Text);
                        a.Parameters.AddWithValue("telephone", telephoneMTB.Text);
                        if (atCheck)
                        {
                            a.Parameters.AddWithValue("email", emailTB.Text + endingEmailCB.SelectedItem);
                        }
                        else
                        {
                            a.Parameters.AddWithValue("email", emailTB.Text);
                        }
                        a.Parameters.AddWithValue("useDelivery", checkDeliveryCB.CheckState);
                        if (a.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Добавление прошло успешно!");
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с таки логином уже зарегистрирован!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show($"Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registrationForm_Load(object sender, EventArgs e)
        {
            try
            {
                DBHElper.openConnection(ref DBHElper.sqlConnection);

                addressInfoP.Visible = false;
                this.Size = new Size(546, 276);
                this.MinimumSize = new Size(546, 276);
                this.MaximumSize = new Size(546, 276);
                regBTN.Location = new Point(396, 208);

                SqlCommand a = new SqlCommand($"select gender_name from genders", DBHElper.sqlConnection);
                SqlDataReader reader = a.ExecuteReader();
                while (reader.Read())
                {
                    genderCB.Items.Add(reader.GetString(0));
                }
                reader.Close();

                endingEmailCB.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show($"Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkDeliveryCB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkDeliveryCB.Checked)
                {
                    addressInfoP.Visible = true;
                    this.Size = new Size(546, 364);
                    this.MinimumSize = new Size(546, 364);
                    this.MaximumSize = new Size(546, 364);
                    regBTN.Location = new Point(397, 294);

                }
                else
                {
                    addressInfoP.Visible = false;
                    this.Size = new Size(546, 276);
                    this.MinimumSize = new Size(546, 276);
                    this.MaximumSize = new Size(546, 276);
                    regBTN.Location = new Point(396, 208);
                }
            }
            catch
            {
                MessageBox.Show($"Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool atCheck = true;

        private void emailTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (emailTB.Text.Contains('@'))
                {
                    endingEmailCB.Visible = false;
                    emailTB.Size = new Size(179, 20);
                    atCheck = false;
                }
                else
                {
                    endingEmailCB.Visible = true;
                    emailTB.Size = new Size(100, 20);
                    atCheck = true;
                }
            }
            catch
            {
                MessageBox.Show($"Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool checkShowPassword = true;

        private void label16_Click(object sender, EventArgs e)
        {
            try
            {
                Point a;
                if (checkShowPassword)
                {
                    passwordTB.PasswordChar = '\0';
                    showPasswordL.Text = "скрыть пароль";
                    a = new Point(436, 171);
                    checkShowPassword = !checkShowPassword;
                }
                else
                {
                    passwordTB.PasswordChar = '●';
                    showPasswordL.Text = "показать пароль";
                    a = new Point(426, 171);
                    checkShowPassword = !checkShowPassword;
                }
                showPasswordL.Location = a;
            }
            catch
            {
                MessageBox.Show($"Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
