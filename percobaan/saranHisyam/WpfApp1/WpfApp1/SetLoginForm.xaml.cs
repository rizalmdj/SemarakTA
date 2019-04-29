using OpenQA.Selenium.Chrome;
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
using WpfApp1.Model;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class SetLoginForm : Window
    {
        MUser data = new MUser();
        List<Activity> Activities;
        ChromeDriver driver;
        public SetLoginForm(List<Activity> _Activities, ChromeDriver _driver)
        {
            InitializeComponent();
            Activities = _Activities;
            driver = _driver;
            Console.WriteLine("Set div Login");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            data.DivUser = DivUser.Text;
            data.DivPas = DivPas.Text;
            data.Button = DivTom.Text;
            Console.WriteLine("--------Set Login Ke simpan---------");
            Close();
        }
    }
}
