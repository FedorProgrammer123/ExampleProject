using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class User_Cabinet : Form
    {
        public User_Cabinet(string username, string female, string email, string login)
        {
            InitializeComponent();
            Show_name.Text = $"Добро пожаловать, {username}";
            Show_female.Text = $"Фамилия: {female}";
            Show_email.Text = $"Email: {email}";
            Show_login.Text = $"Login: {login}";
        }

        private void Close_App_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void User_Cabinet_Load(object sender, EventArgs e)
        {

        }

        private void GoToExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("До свидания");
            Autorization aut = new Autorization();
            this.Close();
            aut.Show();
        }
    }
}
