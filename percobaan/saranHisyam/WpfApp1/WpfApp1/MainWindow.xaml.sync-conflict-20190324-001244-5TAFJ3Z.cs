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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Model;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ChromeDriver driver;
        public MainWindow()
        {
            InitializeComponent();
            driver = new ChromeDriver(@"C:\Users\Hari\source\repos\WpfApp1\Driver");
        }

        List<Activity> Activities = new List<Activity>();
       

        //menu buat ambil url
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenUrlForm open = new OpenUrlForm(Activities, driver);

            open.ShowDialog();
            list.ItemsSource = null;
            list.ItemsSource = Activities;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

           
                foreach (Activity a in Activities)
                {
                    a.run();
                }
                foreach(KeyValuePair<String, String> p in DataSingleton.Instance.data)
                {
                    Console.WriteLine(p.Key + " = " + p.Value);
                    //hasil.ItemsSource = null;
              
                   
                }
            hasil.ItemsSource = DataSingleton.Instance.data.Values.ToList();
        

        }
        //Menu Untuk ambil data web
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            GetDataForm open = new GetDataForm(Activities, driver);
            open.ShowDialog();
            list.ItemsSource = null;
            list.ItemsSource = Activities;
        }
        //menu buat bikin login page
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
