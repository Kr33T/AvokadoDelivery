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
    public partial class changeAuthData : Form
    {
        SqlCommand query = null;

        public changeAuthData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = new SqlCommand($"select count(*) from buyers where id_buyer like '{authForm.userId}' and password like '{checkPasswordTB.Text}'", DBHElper.sqlConnection);
                if (query.ExecuteScalar().ToString().Equals("1"))
                {
                    panel1.Visible = false;
                    this.Size = new Size(233, 312);
                }
                else
                {
                    MessageBox.Show($"Пароль не совпадает!", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show($"Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeAuthData_Load(object sender, EventArgs e)
        {
            try
            {
                domainUpDown1.SelectedIndex = 0;
                query = new SqlCommand($"select login from buyers where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
                loginTB.Text = query.ExecuteScalar().ToString();
                panel1.Location = new Point(0, 0);
                panel1.BringToFront();
                this.Size = new Size(258, 139);
            }
            catch
            {
                MessageBox.Show($"Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                switch (domainUpDown1.SelectedIndex)
                {
                    case 0:
                        if (passwordTB.Text == applyPasswordTB.Text)
                        {
                            query = new SqlCommand($"select password from buyers where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
                            if (!passwordTB.Text.Equals(query.ExecuteScalar().ToString()))
                            {
                                query = new SqlCommand($"update buyers set password = @password where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
                                query.Parameters.AddWithValue("password", passwordTB.Text);
                                var res = MessageBox.Show("Уверены, что хотите изменить gfhjkm?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (res == DialogResult.Yes)
                                {
                                    if (query.ExecuteNonQuery().ToString().Equals("1"))
                                    {
                                        MessageBox.Show("Изменение пароля прошло успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Действие отменено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Такой пароль используется в данный момент!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 1:
                        query = new SqlCommand($"select login from buyers where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
                        if (!loginTB.Text.Equals(query.ExecuteScalar().ToString()))
                        {
                            query = new SqlCommand($"update buyers set login = @login where id_buyer like '{authForm.userId}'", DBHElper.sqlConnection);
                            query.Parameters.AddWithValue("login", loginTB.Text);
                            var res = MessageBox.Show("Уверены, что хотите изменить логин?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (res == DialogResult.Yes)
                            {
                                if (query.ExecuteNonQuery().ToString().Equals("1"))
                                {
                                    MessageBox.Show("Изменение логина прошло успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Действие отменено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Такой логин уже используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show($"Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show($"Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool showPassword = true;

        private void showPasswordL_Click(object sender, EventArgs e)
        {
            try
            {
                Point a;
                if (showPassword)
                {
                    passwordTB.PasswordChar = '\0';
                    applyPasswordTB.PasswordChar = '\0';
                    showPasswordL.Text = "скрыть пароль";
                    a = new Point(113, 190);
                    showPassword = !showPassword;
                }
                else
                {
                    passwordTB.PasswordChar = '●';
                    applyPasswordTB.PasswordChar = '●';
                    showPasswordL.Text = "показать пароль";
                    a = new Point(103, 190);
                    showPassword = !showPassword;
                }
                showPasswordL.Location = a;
            }
            catch
            {
                MessageBox.Show($"Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            try
            {
                switch (domainUpDown1.SelectedIndex)
                {
                    case 0:
                        loginTB.Visible = label2.Visible = false;
                        label3.Visible = label4.Visible = passwordTB.Visible = applyPasswordTB.Visible = showPasswordL.Visible = true;
                        break;
                    case 1:
                        loginTB.Visible = label2.Visible = true;
                        label3.Visible = label4.Visible = passwordTB.Visible = applyPasswordTB.Visible = showPasswordL.Visible = false;
                        break;
                }
            }
            catch
            {
                MessageBox.Show($"Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
