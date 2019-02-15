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

using WpfApp1.Model;

using System.Drawing.Imaging;

namespace WpfApp1
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
        // panggil model user untuk login
        User user = new User();

        private void button_Click(object sender, RoutedEventArgs e)
        {
            user.email = MyTextBox1.Text;
            user.pass = MyTextBox2.Password;

            //driver untuk run di google crome 
            using (var driver = new ChromeDriver(@"C:\Users\Hari\source\repos\WpfApp1\Driver"))
            {
                // Go to the home page
                driver.Navigate().GoToUrl("https://indihome.co.id/verifikasi-layanan/cek-email");
                //deklarasi variabel di web cek email
                var userNameField = driver.FindElementByXPath("/html/body/div[4]/div/div/div[1]/div/form/div/input");
                userNameField.SendKeys(user.email);
                driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[1]/div/form/button")).Click();

                //deklarasi variabel di web pass
                var userPasswordField = driver.FindElementByXPath("/html/body/div[4]/div/div/div[1]/div/form/div[2]/input");
                userPasswordField.SendKeys(user.pass);
                driver.FindElement(By.XPath(" / html / body / div[4] / div / div / div[1] / div / form / button")).Click();

                //get data pengguna nya
                driver.FindElement(By.XPath("//*[@id='navbar']/ul/li[5]/a/span")).Click();
                driver.Navigate().GoToUrl("https://indihome.co.id/profile/status-langganan");
                //driver.FindElement(By.XPath("//*[@id='mySidenav']/div/table[2]/tbody/tr[1]/td[2]/a")).Click();
                var result = driver.FindElementByXPath("//*[@id='myCarousel']/div/div/div/div[1]/div[1]/div/div[2]/h4").Text;
                File.WriteAllText(@"D:\nitip\Data_Kuliah_SM6_FIX\Semarak TA\WpfApp1result.txt", result);
                Console.WriteLine(result);

                //driver.FindElement(By.Id("loginbutton")).Click();


                //var post = driver.FindElementByXPath("//textarea[@name='xhpc_message']");
                //post.SendKeys("Tes post BY SELENIUM");




                // Extract the text and save it into result.txt
                //var result = driver.FindElementByXPath("//*[@id='js - pjax - container']/div/div[1]/div[4]/h1/span[2]").Text;
                //File.WriteAllText(@"D:\nitip\Data_Kuliah_SM6_FIX\Semarak TA\WpfApp1result.txt", result);
                //Console.WriteLine(result);
                // Take a screenshot and save it into screen.png
                //driver.GetScreenshot().SaveAsFile(@"screen.png", ImageFormat.Png);
            }
        }

    }
}
