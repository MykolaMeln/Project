﻿using System;
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

namespace Project
{
    /// <summary>
    /// Логика взаимодействия для Log_in.xaml
    /// </summary>
    public partial class Log_in : Window//вхід
    {
        string connectionString = @"Data Source=.\SQLEXPRESS1; Initial Catalog=project;Integrated Security=True";
        public Log_in()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                int count = 0;

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Login=@log AND Password=@pas", conn))
                {
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
                        cmd.Parameters.AddWithValue("@pas", password.Password.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Length password = 0");
                    }
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            count += 1;
                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("Password Or Login Error");
                    return;
                }
            }
            Admin(login.Text, password.Password.ToString());
            this.Close();
        }
        public void Admin(string log, string pass)
        {           
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataReader da = new SqlCommand("SELECT Login, Password, Admin FROM Users", conn).ExecuteReader();
            Users us = new Users();
            while (da.Read())
            {
                us.users.Add(new User { Login = da.GetString(0), Password = da.GetString(1), Index = da.GetInt32(2) });
            }

            foreach (User user in us.users)
            {
                if ((user.Index == 1) && (user.Login == log) && (user.Password == pass))
                {
                    Menu win1 = new Menu();
                    win1.loginlabel.Content = login.Text;
                    win1.passlabel.Content = password.Password.ToString();                   
                    win1.users.Visibility = Visibility.Visible;
                    win1.radioinfo.Visibility = Visibility.Visible;
                    win1.chastota.Visibility = Visibility.Hidden;
                    win1.name.Visibility = Visibility.Hidden;
                    win1.chast.Visibility = Visibility.Hidden;
                    win1.addprogram.Visibility = Visibility.Visible;
                    win1.Show();
                }
                else
                if ((user.Index == 0) && (user.Login == log) && (user.Password == pass))
                {
                    Menu win1 = new Menu();
                    win1.loginlabel.Content = login.Text;
                    win1.passlabel.Content = password.Password.ToString();
                    win1.deluser.Visibility = Visibility.Hidden;
                    win1.users.Visibility = Visibility.Hidden;
                    win1.radioinfo.Visibility = Visibility.Visible;
                    win1.Show();
                }
            }

        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
              this.Close();
        }
    }
}
