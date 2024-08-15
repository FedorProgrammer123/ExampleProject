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
    public partial class Admin_Cabinet : Form
    {
        public Admin_Cabinet(string admin_name)
        {
            InitializeComponent();
            Show_name.Text = $"Добро пожаловать, {admin_name}";
        }

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Cabinet_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("До свидания");
            Autorization aut = new Autorization();
            this.Close();
            aut.Show();
        }

        private void ShowUserButton_Click(object sender, EventArgs e)
        {
            string enterquery = EnterQueryBox.Text;
            if (enterquery == "" || enterquery == " ")
            {
                MessageBox.Show("Введите запрос на выборку");
            }
            else
            {
                SQLiteConnection connect = new SQLiteConnection("Data Source = MyApp.db");
                try
                {
                    connect.Open();
                    SQLiteDataAdapter dt = new SQLiteDataAdapter(enterquery, connect);
                    DataSet ds = new DataSet();
                    dt.Fill(ds);
                    dataUsersView.DataSource = ds.Tables[0];
                    connect.Close();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка в бд");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка в приложении");
                }
            }
        }
    }
}
