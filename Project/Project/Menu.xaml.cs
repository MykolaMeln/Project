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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;


namespace Project
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=project;Integrated Security=True";
        public Menu()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {

            name.Content = "Radio4";
            rozklad.Items.Add("rozklad41");
            rozklad.Items.Add("rozklad42");
            rozklad.Items.Add("rozklad43");
            rozklad.Items.Add("rozklad44");
            rozklad.Items.Add("rozklad45");
            rozklad.Items.Add("rozklad46");
            /* SqlConnection conn = new SqlConnection(connectionString);
             conn.Open();
             SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", conn);
             DataSet ds = new DataSet();
             da.Fill(ds, "Users");
             radio.ItemsSource = ds.Tables["Users"].DefaultView;*/
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");
            DataTable t;
            t = ds.Tables["Users"];

            radio.ItemsSource = t.DefaultView;

          //  t.AcceptChanges();

       /*     public UsersTableAdapter adapter;
            DataSet1 dataset = new DataSet1();
            */

    }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
              name.Content = "Radio1";
            rozklad.Items.Add("rozklad1");
            rozklad.Items.Add("rozklad2");
            rozklad.Items.Add("rozklad3");
            rozklad.Items.Add("rozklad4");
            rozklad.Items.Add("rozklad5");
            rozklad.Items.Add("rozklad6");

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
             name.Content = "Radio2";
            rozklad.Items.Add("rozklad21");
            rozklad.Items.Add("rozklad22");
            rozklad.Items.Add("rozklad23");
            rozklad.Items.Add("rozklad24");
            rozklad.Items.Add("rozklad25");
            rozklad.Items.Add("rozklad26");

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            name.Content = "Radio3";
            rozklad.Items.Add("rozklad31");
            rozklad.Items.Add("rozklad32");
            rozklad.Items.Add("rozklad33");
            rozklad.Items.Add("rozklad34");
            rozklad.Items.Add("rozklad35");
            rozklad.Items.Add("rozklad36"); 
         
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Log_in lin = new Log_in();
            lin.Show();
            this.Close();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (userdel.Text != loginlabel.Content.ToString())
            {
                string del = "DELETE FROM Users WHERE Login=@log";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(del, connection);
                    command.Parameters.AddWithValue("@log", userdel.Text);
                    command.ExecuteNonQuery();

                }
                MessageBox.Show(userdel.Text + "Deleted");

                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Users");
                DataTable t;
                t = ds.Tables["Users"];
                radio.ItemsSource = t.DefaultView;
                userdel.Text = "";
            }
            else
            userdel.Text = "";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");
            DataTable t;
            t = ds.Tables["Users"];
            radio.ItemsSource = t.DefaultView;
            deluser.Visibility = Visibility.Visible;

        }
    }
}
