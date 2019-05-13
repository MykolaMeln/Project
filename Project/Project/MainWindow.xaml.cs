using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace Project
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window//реєстрація
    { 
        string connectionString = @"Data Source=.\SQLEXPRESS1;Initial Catalog=project;Integrated Security=True";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            Account account = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if ((login.Text.Length != 0) && (password.Password.ToString().Length != 0))
                {
                    user.Login = login.Text;
                    user.Password = password.Password.ToString();
                    int val = 0;
                    if (index.IsChecked == true)
                    {
                        val = 1;
                    }
                    user.Index = val;
                    account = Account.getInstance(user);
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO Users (Login,Password,Admin) VALUES(@log,@pwd,@ind) ";
                    cmd.Parameters.AddWithValue("@log", account.Login);
                    cmd.Parameters.AddWithValue("@pwd", account.Password);             
                    cmd.Parameters.AddWithValue("@ind", account.Index);                 
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Login or Password is NULL");
                }
            }
            Menu menu = new Menu();
            menu.loginlabel.Content = account.Login;
            menu.Show();
            this.Close();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            var w2 = new Log_in();
            w2.Show();
            this.Close();
        }
    }
}
