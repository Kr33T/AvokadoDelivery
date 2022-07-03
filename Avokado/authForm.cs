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
    public partial class authForm : Form
    {
        public static string userName = null, userId = null;
        public authForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DBHElper.openConnection(ref DBHElper.sqlConnection);
            }
            catch
            {
                MessageBox.Show($"Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signInBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(loginTB.Text))
                {
                    SqlCommand a = new SqlCommand($"select count(*) from buyers where login like '{loginTB.Text}' and password like '{passwordTB.Text}'", DBHElper.sqlConnection);
                    if (a.ExecuteScalar().ToString().Equals("1"))
                    {
                        a = new SqlCommand($"select name from buyers where login like '{loginTB.Text}' and password like '{passwordTB.Text}'", DBHElper.sqlConnection);
                        userName = a.ExecuteScalar().ToString();
                        a = new SqlCommand($"select id_buyer from buyers where login like '{loginTB.Text}' and password like '{passwordTB.Text}'", DBHElper.sqlConnection);
                        userId = a.ExecuteScalar().ToString();
                        mainMenu menu = new mainMenu();
                        menu.Show();
                        this.Hide();

                        menu.FormClosing += (obj, args) =>
                        {
                            loginTB.Text = "";
                            passwordTB.Text = "";
                            this.Show();
                        };
                    }
                    else
                    {
                        Controls.Add(new Label() { Text = "Такого пользователя нет в базе!", Location = new Point(0, 0), ForeColor = Color.FromArgb(200, 0, 0) });
                    }
                }
                else
                {
                    MessageBox.Show("Поле ЛОГИН пустое!");
                }
            }
            catch
            {
                MessageBox.Show($"Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signUpL_Click(object sender, EventArgs e)
        {
            try
            {
                registrationForm reg = new registrationForm();
                reg.Show();
                this.Hide();

                reg.FormClosing += (obj, args) =>
                {
                    this.Show();
                };
            }
            catch
            {
                MessageBox.Show($"Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool showPassword = true;
        
        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                Point a;
                if (showPassword)
                {
                    passwordTB.PasswordChar = '\0';
                    showPasswordL.Text = "скрыть пароль";
                    a = new Point(381, 262);
                    showPassword = !showPassword;
                }
                else
                {
                    passwordTB.PasswordChar = '●';
                    showPasswordL.Text = "показать пароль";
                    a = new Point(371, 262);
                    showPassword = !showPassword;
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
