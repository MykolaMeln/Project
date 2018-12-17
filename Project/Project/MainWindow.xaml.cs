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

namespace Project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=project;Integrated Security=True";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Users (Login,Password,Admin) VALUES(@log,@pwd,@ind) ";
                if (login.Text.Length != 0)
                {
                    cmd.Parameters.AddWithValue("@log", login.Text);
                }
                else
                {
                    MessageBox.Show("Length login = 0");
                }
                if (password.Password.ToString().Length != 0)
                {
                    cmd.Parameters.AddWithValue("@pwd", password.Password.ToString());
                }
                else
                {
                    MessageBox.Show("Length password = 0");
                }
                int val=0;
                if(index.IsChecked == true)
                {
                    val = 1;
                }
                else
                {
                    val = 0;
                }
                cmd.Parameters.AddWithValue("@ind", val);
                cmd.ExecuteNonQuery();
            }
                var menu = new Menu();
                menu.loginlabel.Content = login.Text;
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
