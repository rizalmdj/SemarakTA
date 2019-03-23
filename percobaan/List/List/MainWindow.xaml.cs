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

using System.IO;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class Part 
        {
            public string PartName { get; set; }
            public string PartId { get; set; }

            public override string ToString()
            {
                return "ID: " + PartId + "   Name: " + PartName;
            }
        
        }

        List<Part> parts = new List<Part>();
        //List<string> mylist = new List<string>();
        private void Save(object sender, RoutedEventArgs e)
        {
           
            if (this.input.Text != "")
            {
                parts.Add(new Part() { PartName = div.Text, PartId = input.Text });
                
               
                list.ItemsSource = null;
                list.ItemsSource = parts;
            }
            else
            {
                MessageBox.Show("hAHAHAHAHAH", "ERROR");
                this.input.Focus();
            }

           

        }

        private void toboCari_Click(object sender, RoutedEventArgs e)
        {

            //string konten = parts.Find(x => x.PartId.Contains(cari.Text)).PartName;
            try
            {
                Hasil.Content = parts.Find(x => x.PartId.Contains(cari.Text)).PartName;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error");
                this.input.Focus();
            }

        }

        private void runweb()
        {
            string web = url.Text;
            using (var driver = new ChromeDriver(@"C:\Users\Hari\source\repos\WpfApp1\Driver"))
            {
                driver.Navigate().GoToUrl(web);

                parts.Select(x =>  x.PartId = driver.FindElementByXPath(x.PartName).Text);
                Console.WriteLine("hahaha");
                parts.ForEach(x => Console.WriteLine(x.PartId));
                parts.ForEach(x => x.PartId = driver.FindElementByXPath(x.PartName).Text);
                //Hasil.Content = parts.Find(x => x.PartId.Contains(cari.Text)).PartName;
                parts.ForEach(x => Console.WriteLine(x.PartId));

            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            runweb();

        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = parts;
            comboBox.SelectedIndex = 0;

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... Get the ComboBox.
            var comboBox = sender as ComboBox;

            // ... Set SelectedItem as Window Title.
            string value = comboBox.SelectedItem as string;
            this.Title = "Selected: " + value;

            Console.WriteLine(value);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 win2 = new Window1();
            win2.Show();
        }
    }
}
