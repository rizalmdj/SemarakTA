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

using PerFlow.Model;

namespace PerFlow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Login login;
        public MainWindow()
        {
            login = new Login();
            InitializeComponent();
        }


       
        private void Tambah(object sender, RoutedEventArgs e)
        {
           // Login login = new Login();
            login.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           // var instance =  new Login();
           
            login.runLogin();
        }
    }
}
