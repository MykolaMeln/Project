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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            name.Content = "Radio1";
            rozklad.Items.Add("rozklad1");
            rozklad.Items.Add("rozklad2");
            rozklad.Items.Add("rozklad3");
            rozklad.Items.Add("rozklad4");
            rozklad.Items.Add("rozklad5");
            rozklad.Items.Add("rozklad6");

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            name.Content = "Radio2";
            rozklad.Items.Add("rozklad21");
            rozklad.Items.Add("rozklad22");
            rozklad.Items.Add("rozklad23");
            rozklad.Items.Add("rozklad24");
            rozklad.Items.Add("rozklad25");
            rozklad.Items.Add("rozklad26");

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            name.Content = "Radio3";
            rozklad.Items.Add("rozklad31");
            rozklad.Items.Add("rozklad32");
            rozklad.Items.Add("rozklad33");
            rozklad.Items.Add("rozklad34");
            rozklad.Items.Add("rozklad35");
            rozklad.Items.Add("rozklad36");

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            name.Content = "Radio4";
            rozklad.Items.Add("rozklad41");
            rozklad.Items.Add("rozklad42");
            rozklad.Items.Add("rozklad43");
            rozklad.Items.Add("rozklad44");
            rozklad.Items.Add("rozklad45");
            rozklad.Items.Add("rozklad46");

        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Log_in lin = new Log_in();
            lin.Show();
            this.Close();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
