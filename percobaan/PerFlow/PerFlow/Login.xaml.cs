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
using PerFlow.Model;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PerFlow
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        mLogin data;
        public Login()
        {
            data = new mLogin();
            InitializeComponent();
        }




        public void Save(object sender, RoutedEventArgs e)
        {

            data.id = id.Text;
            data.url = url.Text;
            data.user = userName.Text;
            data.divUser = divUser.Text;
            data.pass = pass.Text;
            data.divPass = divPass.Text;
            data.divButton = divTom.Text;


            Console.WriteLine("sjdia");
            Console.WriteLine(data.url);
        }

         public void runLogin()
         {
            using (var driver = new ChromeDriver(@"C:\Users\Hari\source\repos\WpfApp1\Driver"))
            {
                
                driver.Navigate().GoToUrl(data.url);
               
            }
         }
    }
}
