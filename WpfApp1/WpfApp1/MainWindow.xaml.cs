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

        private void button_Click(object sender, RoutedEventArgs e)
        {

            var user = MyTextBox1.Text;
            var pass = MyTextBox2.Password;

            //IWebDriver driver2 = new ChromeDriver(@"C:\Users\Hari\source\repos\WpfApp1\Driver");
            using (var driver = new ChromeDriver(@"C:\Users\Hari\source\repos\WpfApp1\Driver"))
            {
                // Go to the home page
                driver.Navigate().GoToUrl("https://www.facebook.com");

                // Get the page elements
                
                var userNameField = driver.FindElementByXPath("//*[@id='email']");
                var userPasswordField = driver.FindElementByXPath("//*[@id='pass']");
                
              
                userNameField.SendKeys(user);
                userPasswordField.SendKeys(pass);

                
                driver.FindElement(By.Id("loginbutton")).Click();


                var post = driver.FindElementByXPath("//textarea[@name='xhpc_message']");
                post.SendKeys("Tes post BY SELENIUM");

                
                driver.FindElement(By.XPath("//*[@id='js_20']/div[2]/div[3]/div[2]/div/div/button")).Click();

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
