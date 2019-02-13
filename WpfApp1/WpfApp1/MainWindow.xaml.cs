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
            //IWebDriver driver2 = new ChromeDriver(@"C:\Users\Hari\source\repos\WpfApp1\Driver");
            using (var driver = new ChromeDriver(@"C:\Users\Hari\source\repos\WpfApp1\Driver"))
            {
                // Go to the home page
                driver.Navigate().GoToUrl("http://testing-ground.scraping.pro/login");

                // Get the page elements
                var userNameField = driver.FindElementById("usr");
                var userPasswordField = driver.FindElementById("pwd");
                var loginButton = driver.FindElementByXPath("//input[@value='Login']");

                // Type user name and password
                userNameField.SendKeys("admin");
                userPasswordField.SendKeys("12345");

                // and click the login button
                loginButton.Click();

                // Extract the text and save it into result.txt
                var result = driver.FindElementByXPath("//div[@id='case_login']/h3").Text;
                File.WriteAllText("result.txt", result);

                // Take a screenshot and save it into screen.png
                //driver.GetScreenshot().SaveAsFile(@"screen.png", ImageFormat.Png);
            }
        }
    }
}
