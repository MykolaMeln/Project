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
    public partial class Menu : Window//основне меню
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");
        public Menu()
        {
            InitializeComponent();
            StaticRating();
        }
        private void Programs()
        {
            radioinfo.Visibility = Visibility.Visible;
            name.Visibility = Visibility.Visible;
            chastota.Visibility = Visibility.Visible;
            chast.Visibility = Visibility.Visible;   
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Programs WHERE ID_Station='" + name.Content + "' ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Programs");
            DataTable t;
            t = ds.Tables["Programs"];
            rozklad.ItemsSource = t.DefaultView;
            conn.Close();
            rozklad.CanUserResizeRows = false;
            rozklad.CanUserResizeColumns = false;
            rozklad.CanUserDeleteRows = false;
            rozklad.CanUserAddRows = false;
            rozklad.IsReadOnly = true;
            addprog.Visibility = Visibility.Hidden;
            deluser.Visibility = Visibility.Hidden;
            favorites.Visibility = Visibility.Hidden;
        }
        private void Chastota()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Frequency FROM Radio_Stations WHERE Name_Station='" + name.Content + "' ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Radio_Stations");
            DataTable t;
            t = ds.Tables["Radio_Stations"];
            foreach (DataRow row in t.Rows)
            {
                foreach (DataColumn col in t.Columns)
                {
                    chastota.Content = row[col].ToString() + " Ghz";
                }

            }
            conn.Close();

        }
        private void Rating(string name)
        {
            Rating rt = new Rating();
            rt.Update(name);       
        }
        private void StaticRating()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Name_Station, Rating FROM Radio_Stations ORDER BY Rating DESC", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Radio_Stations");
            DataTable t;
            t = ds.Tables["Radio_Stations"];
            ratings.ItemsSource = t.DefaultView;
            ratings.IsReadOnly = true;
            conn.Close();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)//Radiopepper
        {
            name.Content = radio1.Content;
            Programs();
            Chastota();
            Rating(name.Content.ToString());
            StaticRating();
        }
        private void Button2_Click(object sender, RoutedEventArgs e)//Bukovyna
        {
            name.Content = radio2.Content;
            Programs();
            Chastota();
            Rating(name.Content.ToString());
            StaticRating();
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            name.Content = radio3.Content;
            Programs();
            Chastota();
            Rating(name.Content.ToString());
            StaticRating();
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            name.Content = radio4.Content;
            Programs();
            Chastota();
            Rating(name.Content.ToString());
            StaticRating();
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            name.Content = radio5.Content;
            Programs();
            Chastota();
            Rating(name.Content.ToString());
            StaticRating();
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            name.Content = radio6.Content;
            Programs();
            Chastota();
            Rating(name.Content.ToString());
            StaticRating();
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
                    conn.Open();
                    SqlCommand command = new SqlCommand(del, conn);
                    command.Parameters.AddWithValue("@log", userdel.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show(userdel.Text + " Deleted");

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Users");
                DataTable t;
                t = ds.Tables["Users"];
                radio.ItemsSource = t.DefaultView;
                radio.IsReadOnly = true;
                conn.Close();
                userdel.Text = "";
            }
            else
            userdel.Text = "";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Users");
            DataTable t;
            t = ds.Tables["Users"];
            radio.ItemsSource = t.DefaultView;
            conn.Close();
            radio.Visibility = Visibility.Visible;
            radio.IsReadOnly = true;
            deluser.Visibility = Visibility.Visible;
            radioinfo.Visibility = Visibility.Hidden;
            addprog.Visibility = Visibility.Hidden;
            favorites.Visibility = Visibility.Hidden; ;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            radioinfo.Visibility = Visibility.Hidden;
            favorites.Visibility = Visibility.Hidden;
            deluser.Visibility = Visibility.Hidden;
            addprog.Visibility = Visibility.Visible;
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            if ((namestation.Text!="")&&(nameprogram.Text!="")&&(period.Text!="")&&(hourbegin.Text!="")&&(hourend.Text!=""))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Programs(ID_Station,Name_Program,Period,Hour_Begin,Hour_End) VALUES(@namer,@namep,@per,@hourb,@houre)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@namer", namestation.Text);
                cmd.Parameters.AddWithValue("@namep", nameprogram.Text);
                cmd.Parameters.AddWithValue("@per", period.Text);
                cmd.Parameters.AddWithValue("@hourb", hourbegin.Text);
                cmd.Parameters.AddWithValue("@houre", hourend.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Please Try Again");
                return;
            }
            namestation.Text = "";
            nameprogram.Text = "";
            period.Text = "";
            hourbegin.Text = "";
            hourend.Text = "";
        }

        private void Button13_Click(object sender, RoutedEventArgs e)
        {
            if (namefav.Text != "")
            {
                Favorites fav = new Favorites(loginlabel.Content.ToString(), namefav.Text);
                fav.AddFavorite();
                MessageBox.Show("Record Added Successfully");
                namefav.Text = "";
            }
            else
            {
                MessageBox.Show("Please Try Again");
                return;
            }       
        }
        public void ShowFavorite()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID_Station FROM Favorites WHERE ID_User='" + loginlabel.Content.ToString() + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Radio_Stations");
            DataTable t;
            t = ds.Tables["Radio_Stations"];
            favorit.ItemsSource = t.DefaultView;
            favorit.IsReadOnly = true;
            conn.Close();
        }
        private void Button14_Click(object sender, RoutedEventArgs e)
        {
            favorites.Visibility = Visibility.Visible;
            addprog.Visibility = Visibility.Hidden;
            deluser.Visibility = Visibility.Hidden;
            radio.Visibility = Visibility.Hidden;
            radioinfo.Visibility = Visibility.Hidden;
            ShowFavorite();
        }

        private void Button15_Click(object sender, RoutedEventArgs e)
        {
            if (namefavor.Text != "")
            {
                Favorites fav = new Favorites(loginlabel.Content.ToString(), namefavor.Text);
                fav.DeleteFavorite();
                MessageBox.Show(namefavor.Text + " Deleted");
                namefavor.Text = "";
            }
            else
            {
                MessageBox.Show("Please Try Again");
                return;
            }
            ShowFavorite(); 
            
        }
    }
}
