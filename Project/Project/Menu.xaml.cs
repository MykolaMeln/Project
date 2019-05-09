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
using System.Windows.Media.Animation;

namespace Project
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window//основне меню
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=project;Integrated Security=True");
        public Favorites favoritess;
        public Programs programs;
        public Comments commentss;       
        public Menu()
        {
            InitializeComponent();
            StaticRating();
            programs = new Programs();
            LoadPrograms();
            favoritess = new Favorites();
            LoadFavorites();
            commentss = new Comments();
            LoadComments();
            LoadInBlock();
        }
        private void LoadPrograms()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Programs ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Programs");
            DataTable t;
            t = ds.Tables["Programs"];
            Program program;
            foreach (DataRow row in t.Rows)
            {
                program = new Program(row[0].ToString(),row[1].ToString(),row[2].ToString(),row[3].ToString(),row[4].ToString());
                programs.AddProgram(program);
            }     
            conn.Close();
        }
        private void LoadFavorites()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Favorites Where ID_User='" + loginlabel.Content.ToString() + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Favorites");
            DataTable t;
            t = ds.Tables["Favorites"];
            Favorite favorite;
            foreach (DataRow row in t.Rows)
            {
                favorite = new Favorite(row[0].ToString(), row[1].ToString());
                favoritess.AddFavorite(favorite);
            }
            conn.Close();
        }
        private void LoadComments()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Comments", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Comments");
            DataTable t;
            t = ds.Tables["Comments"];
            Comment comment;
            foreach (DataRow row in t.Rows)
            {
                comment = new Comment(row[0].ToString(), row[1].ToString(), Convert.ToDateTime(row[2]));
                commentss.AddComment(comment);
            }
            conn.Close();
        }
        private void LoadInBlock()
        {
            int k = 1;
            string MyText = "";
            foreach(Comment com in commentss.comments)
            {
                MyText += k.ToString() + ". " + com.user + ": " + com.comment + " " + com.date.ToString() + "\n";
                k++;
            }
        }
        private void IsFavorite(string namestation)
        {
            foreach(Favorite fav in favoritess.favorites)
            {
                if(fav.Station == namestation)
                {
                    addfav.Visibility = Visibility.Hidden;
                    delfav.Visibility = Visibility.Visible;
                }
                else
                {
                    addfav.Visibility = Visibility.Visible;
                    delfav.Visibility = Visibility.Hidden;
                }
            }
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
            logo.Stroke = Brushes.Red;
            logoradio.ImageSource = BitmapFrame.Create(new Uri(@"pack://application:,,,/Project;component/Resources/pepper.png"));
            CloseRadio();
            IsFavorite(radio1.Content.ToString());
            Programs();
            Chastota();
            Rating(name.Content.ToString());
            StaticRating();
        }
        private void Button2_Click(object sender, RoutedEventArgs e)//Bukovyna
        {
            name.Content = radio2.Content;
            logo.Stroke = Brushes.Black;
            logoradio.ImageSource = BitmapFrame.Create(new Uri(@"pack://application:,,,/Project;component/Resources/bukovyna.png"));
            CloseRadio();
            IsFavorite(radio2.Content.ToString());
            Programs();
            Chastota();
            Rating(name.Content.ToString());
            StaticRating();
        }
        private void Button3_Click(object sender, RoutedEventArgs e)//Starlight
        {
            name.Content = radio3.Content;
            logo.Stroke = Brushes.Black;
            logoradio.ImageSource = BitmapFrame.Create(new Uri(@"pack://application:,,,/Project;component/Resources/starlight.png"));
            CloseRadio();
            IsFavorite(radio3.Content.ToString());
            Programs();
            Chastota();
            Rating(name.Content.ToString());
            StaticRating();
        }
        private void Button4_Click(object sender, RoutedEventArgs e)//RadioRock
        {
            name.Content = radio4.Content;
            logo.Stroke = Brushes.Red;
            logoradio.ImageSource = BitmapFrame.Create(new Uri(@"pack://application:,,,/Project;component/Resources/rock.png"));
            CloseRadio();
            IsFavorite(radio4.Content.ToString());
            Programs();
            Chastota();
            Rating(name.Content.ToString());
            StaticRating();
        }

        private void Button11_Click(object sender, RoutedEventArgs e)//UARadio
        {
            name.Content = radio5.Content;
            logo.Stroke = Brushes.Blue;
            logoradio.ImageSource = BitmapFrame.Create(new Uri(@"pack://application:,,,/Project;component/Resources/ua.png"));
            CloseRadio();
            IsFavorite(radio5.Content.ToString());
            Programs();
            Chastota();
            Rating(name.Content.ToString());
            StaticRating();
        }

        private void Button12_Click(object sender, RoutedEventArgs e)//Energy
        {
            name.Content = radio6.Content;
            logo.Stroke = Brushes.Orange;
            logoradio.ImageSource = BitmapFrame.Create(new Uri(@"pack://application:,,,/Project;component/Resources/energy.png"));
            CloseRadio();
            IsFavorite(radio6.Content.ToString());
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
                userss.ItemsSource = t.DefaultView;
                userss.IsReadOnly = true;
                conn.Close();
                userdel.Text = "";
            }
            else
            userdel.Text = "";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (deluser.Visibility == Visibility.Hidden)
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Users");
                DataTable t;
                t = ds.Tables["Users"];
                userss.ItemsSource = t.DefaultView;
                conn.Close();
                userss.Visibility = Visibility.Visible;
                userss.IsReadOnly = true;
                deluser.Visibility = Visibility.Visible;
                radioinfo.Visibility = Visibility.Hidden;
                addprog.Visibility = Visibility.Hidden;
            }
            else
            {
                deluser.Visibility = Visibility.Hidden;
                addprog.Visibility = Visibility.Hidden;
                radioinfo.Visibility = Visibility.Visible;
            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (addprog.Visibility == Visibility.Hidden)
            {
                radioinfo.Visibility = Visibility.Hidden;
                deluser.Visibility = Visibility.Hidden;
                addprog.Visibility = Visibility.Visible;
            }
            else
            {
                addprog.Visibility = Visibility.Hidden;
                deluser.Visibility = Visibility.Hidden;
                radioinfo.Visibility = Visibility.Visible;
            }
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            if ((namestation.Text!="")&&(nameprogram.Text!="")&&(period.Text!="")&&(hourbegin.Text!="")&&(hourend.Text!=""))
            {
                Program p = new Program(namestation.Text, nameprogram.Text, period.Text, hourbegin.Text, hourend.Text);
                programs.AddProgram(p);
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
        private void CloseFav()
        {
            if (favorites.Height == 0)
            {
                favorites.Visibility = Visibility.Visible;
                ShowFavorite();
                DoubleAnimation doubleanimation = new DoubleAnimation();
                doubleanimation.From = 0;
                doubleanimation.To = 295;
                doubleanimation.Duration = TimeSpan.FromSeconds(0.3);
                showfav.BeginAnimation(Button.HeightProperty, doubleanimation);
            }
            else
              if (favorites.Height == 295)
            {
                DoubleAnimation doubleanimation = new DoubleAnimation();
                doubleanimation.From = 295;
                doubleanimation.To = 0;
                doubleanimation.Duration = TimeSpan.FromSeconds(0.3);
                showfav.BeginAnimation(Button.HeightProperty, doubleanimation);
                favorites.Visibility = Visibility.Hidden;
                radioinfo.Visibility = Visibility.Visible;
            }
        }
        private void showfav_Click(object sender, RoutedEventArgs e)
        {
            CloseFav();
            addprog.Visibility = Visibility.Hidden;
            deluser.Visibility = Visibility.Hidden;
            userss.Visibility = Visibility.Hidden;
        }
        private void closefav_Click(object sender, RoutedEventArgs e)
        {
            CloseFav();
            addprog.Visibility = Visibility.Hidden;
            deluser.Visibility = Visibility.Hidden;
            userss.Visibility = Visibility.Hidden;
        }
        private void Button13_Click(object sender, RoutedEventArgs e)
        {
            Favorite fav = new Favorite(loginlabel.Content.ToString(), name.Content.ToString());
            MessageBox.Show(favoritess.AddFavorite(fav));
            addfav.Visibility = Visibility.Hidden;
            delfav.Visibility = Visibility.Visible;
        }
        private void Button15_Click(object sender, RoutedEventArgs e)
        {
            Favorite fav = new Favorite(loginlabel.Content.ToString(), name.Content.ToString());
            favoritess.DeleteFavorite(fav);
            addfav.Visibility = Visibility.Visible;
            delfav.Visibility = Visibility.Hidden;
        }
        private void CloseRadio()
        {
            if (radiost.Height == 360)
            {        
                DoubleAnimation doubleanimation = new DoubleAnimation();
                doubleanimation.From = 360;
                doubleanimation.To = 0;
                doubleanimation.Duration = TimeSpan.FromSeconds(0.3);
                radiost.BeginAnimation(Button.HeightProperty, doubleanimation);
                down.Visibility = Visibility.Visible;
            }
        }
        private void ShowRadio()
        {
            if(radiost.Height == 0)
            {
                radiost.Visibility = Visibility.Visible;
                DoubleAnimation doubleanimation = new DoubleAnimation();
                doubleanimation.From = 0;
                doubleanimation.To = 360;
                doubleanimation.Duration = TimeSpan.FromSeconds(0.3);
                radiost.BeginAnimation(Button.HeightProperty, doubleanimation);
            }
        }
        private void settings_Click(object sender, RoutedEventArgs e)
        {
            ShowSet();
        }

        private void listradio_Click(object sender, RoutedEventArgs e)
        {
            CloseRadio();
        }

        private void downradio_Click(object sender, RoutedEventArgs e)
        {
            ShowRadio();
            down.Visibility = Visibility.Hidden;
        }
        private void CloseSet()
        {
            if (setting.Width == 250)
            {
                DoubleAnimation doubleanimation = new DoubleAnimation();
                doubleanimation.From = 250;
                doubleanimation.To = 0;
                doubleanimation.Duration = TimeSpan.FromSeconds(0.3);
                setting.BeginAnimation(Button.WidthProperty, doubleanimation);
            }
        }
        private void ShowSet()
        {
            if (setting.Width == 0)
            {
                setting.Visibility = Visibility.Visible;
                DoubleAnimation doubleanimation = new DoubleAnimation();
                doubleanimation.From = 0;
                doubleanimation.To = 250;
                doubleanimation.Duration = TimeSpan.FromSeconds(0.3);
                setting.BeginAnimation(Button.WidthProperty, doubleanimation);
            }
            else
                if (setting.Width == 250)
            {
                DoubleAnimation doubleanimation = new DoubleAnimation();
                doubleanimation.From = 250;
                doubleanimation.To = 0;
                doubleanimation.Duration = TimeSpan.FromSeconds(0.3);
                setting.BeginAnimation(Button.WidthProperty, doubleanimation);
                setting.Visibility = Visibility.Hidden;
            }
        }
        private void Closeset_Click(object sender, RoutedEventArgs e)
        {
            CloseSet();
            pass1.Password = "";
            pass2.Password = "";
            pass3.Password = "";
            pass4.Password = "";
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {        
            if (pass4.Password.ToString().Length != 0)
            {
                if (pass4.Password.ToString().CompareTo(passlabel.Content) == 0)
                {
                    string del = "DELETE FROM Users WHERE Login=@log And Password=@pas";
                    conn.Open();
                    SqlCommand command = new SqlCommand(del, conn);
                    command.Parameters.AddWithValue("@log", loginlabel.Content);
                    command.Parameters.AddWithValue("@pas", pass4.Password.ToString());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thanks. Your account is deleted.");
                    pass4.Password = "";
                    MainWindow log = new MainWindow();
                    log.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Wrong password");
            }
            else
                MessageBox.Show("Length of password is null");
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            pass4.Password = "";
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if ((pass1.Password.ToString().Length != 0) && (pass2.Password.ToString().Length != 0) && (pass3.Password.ToString().Length != 0))
            {
                if (pass1.Password.ToString().CompareTo(passlabel.Content) == 0 && (pass2.Password.ToString().CompareTo(pass3.Password.ToString()) == 0))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Users SET Password = @pas WHERE Login=@log", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@log", loginlabel.Content);
                    cmd.Parameters.AddWithValue("@pas", pass3.Password.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Password is changed. New password " + pass3.Password.ToString());
                    pass1.Password = "";
                    pass2.Password = "";
                    pass3.Password = "";
                }
                else
                MessageBox.Show("Wrong password or wrong confirm");
            }
            else
                MessageBox.Show("Length of password is null");
        }

        private void comment_Click(object sender, RoutedEventArgs e)
        {
            string BoldText, CommentText;
            DateTime ItalicText;
            if (comment.Text != "")
            {
                BoldText = loginlabel.Content.ToString();
                ItalicText = DateTime.Now.Date.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute);
                CommentText = comment.Text;
                Comment commentt = new Comment(BoldText, CommentText, ItalicText);
                commentss.AddComment(commentt);
                comment.Text = "";
            }
            else
            {
                MessageBox.Show("Comment length is null!");
            }
            LoadInBlock();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            int index = rozklad.SelectedIndex;

            if (index != -1)
            {
                int k = 0;
                foreach (Program p in programs.programs)
                {
                    if (p.Id_Station == name.Content.ToString())
                    {
                        if(k==index)
                        {
                            programs.DeleteProgram(p);
                            Programs();
                        }
                        else
                            k++;
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Select one row!");
            }
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {

        }       
    }
}
