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

using OpenQA.Selenium.Chrome;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ButtonClik.xaml
    /// </summary>
    public partial class ButtonClik : Window
    {
        List<Activity> Activities;
        ChromeDriver driver;
        MElemet data = new MElemet();

        public ButtonClik(List<Activity> _Activities, ChromeDriver _driver)
        {
            InitializeComponent();
            Activities = _Activities;
            driver = _driver;
            Console.WriteLine("Button clik");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            data.PartName = Nama.Text;
            data.DivElement = DivElement.Text;
            Activity a = new Clik(driver, data);
            Activities.Add(a);
            Console.WriteLine("-----------data berhasil clik kesimpan-------------------");
            Close();
        }
    }
}
