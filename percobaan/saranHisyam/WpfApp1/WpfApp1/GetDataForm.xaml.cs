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
    /// Interaction logic for GetDataForm.xaml
    /// </summary>
    public partial class GetDataForm : Window
    {
        List<Activity> Activities;
        ChromeDriver driver;
        MElemet data = new MElemet();
        public GetDataForm(List<Activity> _Activities, ChromeDriver _driver)
        {
            InitializeComponent();
            Activities = _Activities;
            driver = _driver;
            Console.WriteLine("get data");
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            data.PartName = nama.Text;
            data.DivElement = DivElement.Text;
            Activity a = new GetData(driver, data);
            Activities.Add(a);
            Console.WriteLine("-----------data berhasil kesimpan-------------------");
            Close();
        }
    }
}
