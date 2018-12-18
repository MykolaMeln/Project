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
           
            /* SqlConnection conn = new SqlConnection(connectionString);
             conn.Open();
             SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", conn);
             DataSet ds = new DataSet();
             da.Fill(ds, "Users");
             radio.ItemsSource = ds.Tables["Users"].DefaultView;*/
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Programs WHERE ID_Station=" + name.Content+" ", conn);
            SqlDataAdapter dad = new SqlDataAdapter("SELECT Frequency FROM Radio_Stations WHERE Name_Station=" + name.Content + " ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Programs");
            DataTable t;
            t = ds.Tables["Programs"];
            chastota.Content = dad.ToString() + " GHz";
            rozklad.ItemsSource = t.DefaultView;
            deluser.Visibility = Visibility.Hidden;
            //  t.AcceptChanges();

            /*     public UsersTableAdapter adapter;
                 DataSet1 dataset = new DataSet1();
                 */

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
              name.Content = "Radio1";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Programs WHERE ID_Station=" + name.Content + " ", conn);
            SqlDataAdapter dad = new SqlDataAdapter("SELECT Frequency FROM Radio_Stations WHERE Name_Station=" + name.Content + " ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Programs");
            DataTable t;
            t = ds.Tables["Programs"];
            chastota.Content = dad.ToString() + " GHz";
            rozklad.ItemsSource = t.DefaultView;
            deluser.Visibility = Visibility.Hidden;


        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
             name.Content = "Radio2";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Programs WHERE ID_Station=" + name.Content + " ", conn);
            SqlDataAdapter dad = new SqlDataAdapter("SELECT Frequency FROM Radio_Stations WHERE Name_Station=" + name.Content + " ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Programs");
            DataTable t;
            t = ds.Tables["Programs"];
            chastota.Content = dad.ToString() + " GHz";
            rozklad.ItemsSource = t.DefaultView;
            deluser.Visibility = Visibility.Hidden;


        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            name.Content = "Radio3";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Programs WHERE ID_Station=" + name.Content + " ", conn);
            SqlDataAdapter dad = new SqlDataAdapter("SELECT Frequency FROM Radio_Stations WHERE Name_Station=" + name.Content + " ", conn);

            DataSet ds = new DataSet();
            da.Fill(ds, "Programs");
            DataTable t;
            t = ds.Tables["Programs"];
            chastota.Content = dad.ToString() + " GHz";

            rozklad.ItemsSource = t.DefaultView;
            deluser.Visibility = Visibility.Hidden;

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
            radioinfo.Visibility = Visibility.Hidden;

        }
    }
}
