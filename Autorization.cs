using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace WindowsFormsApp1
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void RegistrationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            this.Hide();
            reg.Show();
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AutorizationButton_Click(object sender, EventArgs e)
        {
            string autlogin = EnterAutLoginBox.Text;
            string autpassword = EnterAutPasswordBox.Text;
            if (autlogin == "" || autlogin == " ")
            {
                MessageBox.Show("Ошибка! Введите логин");
            }
            else if (autpassword == "" || autpassword == " ")
            {
                MessageBox.Show("Ошибка! Пароль не введён");
            }
            else
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source = MyApp.db");
                try
                {
                    conn.Open();
                    SQLiteCommand check_admin = new SQLiteCommand($"SELECT COUNT(*) FROM Adminers WHERE Login = '{autlogin}' AND Password = '{autpassword}'", conn);
                    SQLiteCommand check_users = new SQLiteCommand($"SELECT COUNT(*) FROM Users WHERE Login = '{autlogin}' AND Password = '{autpassword}'", conn);
                    long count_adminers = (long)check_admin.ExecuteScalar();
                    long count_users = (long)check_users.ExecuteScalar();
                    if (count_adminers > 0)
                    {
                        MessageBox.Show("Добро пожаловать, администратор");
                        SQLiteCommand adminer = new SQLiteCommand($"SELECT Name FROM Adminers WHERE Login = '{autlogin}' AND Password = '{autpassword}'",conn);
                        SQLiteDataReader dr = adminer.ExecuteReader();
                        string admin_name;
                        while (dr.Read())
                        {
                            admin_name = dr["Name"].ToString();
                            Admin_Cabinet ac = new Admin_Cabinet(admin_name);
                            this.Hide();
                            ac.Show();
                        }
                    }
                    else if (count_users > 0)
                    {
                        MessageBox.Show("Добро пожаловать");
                        SQLiteCommand sout_name = new SQLiteCommand($"SELECT Name, Female, Email, Login FROM Users WHERE Login = '{autlogin}' AND Password = '{autpassword}'", conn);
                        SQLiteDataReader dr = sout_name.ExecuteReader();
                        string name, female, email, login;
                        while (dr.Read())
                        {
                            name = dr["Name"].ToString();
                            female = dr["Female"].ToString();
                            email = dr["Email"].ToString();
                            login = dr["Login"].ToString();
                            User_Cabinet ucb = new User_Cabinet(name, female, email, login);
                            this.Hide();
                            ucb.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка! Неверный логин или пароль");
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка в бд!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка в приложении" + ex);
                }
            }
        }

        private void ForgottPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
