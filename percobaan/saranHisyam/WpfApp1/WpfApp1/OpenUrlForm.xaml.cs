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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for OpenUrl.xaml
    /// </summary>
    public partial class OpenUrlForm : Window
    {
        List<Activity> Activities;
        ChromeDriver driver;
        public OpenUrlForm(List<Activity> _Activities, ChromeDriver _driver)
        {
            InitializeComponent();
            Activities = _Activities;
            driver = _driver;
            Console.WriteLine(driver);
            Console.WriteLine(driver);
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            Activity a = new OpenUrl(driver, haha.Text);
            Activities.Add(a);
            //Ac = haha.Text;
            Close();
        }
    }
}
