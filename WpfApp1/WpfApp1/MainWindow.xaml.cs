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
        Tagihan bill = new Tagihan();

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
                var userNameField = driver.FindElementByXPath("/html/body/div[3]/div/div/div[1]/div/form/div/input");
                userNameField.SendKeys(user.email);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div/form/button")).Click();

                //deklarasi variabel di web pass
                var userPasswordField = driver.FindElementByXPath("/html/body/div[3]/div/div/div[1]/div/form/div[2]/input");
                userPasswordField.SendKeys(user.pass);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div/form/button")).Click();

                //get data pengguna nya
                driver.Navigate().GoToUrl("https://indihome.co.id/profile/status-langganan");
                user.nomer = driver.FindElementByXPath("//*[@id='myCarousel']/div/div/div/div[1]/div[1]/div/div[2]/h4").Text;
                File.WriteAllText(@"D:\nitip\Data_Kuliah_SM6_FIX\Semarak TA\WpfApp1result.txt", user.nomer);
                Console.WriteLine(user.nomer);
                nomerTlp.Content = user.nomer;
                email.Content = user.email;


                //get data tagihan
                driver.Navigate().GoToUrl("https://indihome.co.id/profile/tagihan");
                bill.bulan = driver.FindElementByXPath("/html/body/div[6]/div/div/div[3]/div/div[2]/div/div[1]/div[1]/div[1]/b").Text;
                bill.totalTagihan = driver.FindElementByXPath("/html/body/div[6]/div/div/div[3]/div/div[2]/div/div[1]/div[3]/div[2]/h4").Text;
                bill.paket = driver.FindElementByXPath("/html/body/div[6]/div/div/div[3]/div/div[2]/div/div[1]/div[3]/div[1]/b").Text;
                bill.Status = driver.FindElementByXPath("/html/body/div[6]/div/div/div[3]/div/div[2]/div/div[1]/div[1]/div[2]/div/p").Text;

                Console.WriteLine(bill.bulan);
                Console.WriteLine(bill.totalTagihan);
                Console.WriteLine(bill.paket);
                Console.WriteLine(bill.Status);
                tag.Content = bill.bulan;
                status.Content = bill.Status;

                //driver.FindElement(By.XPath("//*[@id='mySidenav']/div/table[2]/tbody/tr[1]/td[2]/a")).Click();


                //driver.FindElement(By.Id("loginbutton")).Click();


                //var post = driver.FindElementByXPath("//textarea[@name='xhpc_message']");
                //post.SendKeys("Tes post BY SELENIUM");




                // Extract the text and save it into result.txt
                //var result = driver.FindElementByXPath("//*[@id='js - pjax - container']/div/div[1]/div[4]/h1/span[2]").Text;
                File.WriteAllText(@"D:\nitip\Data_Kuliah_SM6_FIX\Semarak TA\WpfApp1result.txt", user.email);
                //Console.WriteLine(result);
                // Take a screenshot and save it into screen.png
                //driver.GetScreenshot().SaveAsFile(@"screen.png", ImageFormat.Png);
            }
        }

    }
}
