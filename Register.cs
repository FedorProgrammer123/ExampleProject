using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void AutorizationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Autorization aut = new Autorization();
            this.Hide();
            aut.Show();
        }

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string name = EnternameBox.Text;
            string female = EnterfemaleBox.Text;
            string email = EnteremailBox.Text;
            string login = EnterloginBox.Text;
            string password = EnterpasswordBox.Text;
            string confirm_password = EnterconfirmBox.Text;
            if (name == "" || name == " " || female == "" || female == " " || email == "" || email == " " || login == "" || login == " " || password == "" || password == " " || confirm_password == "" || confirm_password == " ")
            {
                MessageBox.Show("Ошибка! Не все поля заполнены");
            }
            else if (password != confirm_password || confirm_password != password)
            {
                MessageBox.Show("Пароли не совпадают");
            }
            else
            {
                SQLiteConnection connect = new SQLiteConnection("Data Source = MyApp.db");
                try
                {
                    connect.Open();
                    using (var create_table = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Users(User_ID INTEGER NOT NULL, Name VARCHAR(50) NOT NULL, Female VARCHAR(50) NOT NULL, Email VARCHAR(50) NOT NULL, Login VARCHAR(50) NOT NULL, Password VARCHAR(50) NOT NULL, Confirm_Password VARCHAR(50) NOT NULL, PRIMARY KEY(User_ID AUTOINCREMENT))",connect))
                    {
                        create_table.ExecuteNonQuery();
                    }
                    SQLiteCommand check_user_email = new SQLiteCommand($"SELECT COUNT(*) FROM Users WHERE Email = '{email}'",connect);
                    SQLiteCommand check_user_login = new SQLiteCommand($"SELECT COUNT(*) FROM Users WHERE Login = '{login}'",connect);
                    if ((long)check_user_email.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Ошибка! Пользователь с таким email уже существует");
                    }
                    else if ((long)check_user_login.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Ошибка! Пользователь с таким логином уже есть в базе");
                    }
                    else
                    {
                        SQLiteCommand insert = new SQLiteCommand($"INSERT INTO Users(User_ID,Name,Female,Email,Login,Password,Confirm_Password)VALUES(NULL,'{name}','{female}','{email}','{login}','{password}','{confirm_password}')", connect);
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Успешная регистрация! Авторизуйтесь пожалуйста");
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка в бд" + ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка в приложении" + ex);
                }
            }
        }
    }
}
