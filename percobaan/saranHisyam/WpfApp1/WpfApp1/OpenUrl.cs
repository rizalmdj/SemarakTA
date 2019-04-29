using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp1
{
    class OpenUrl : Activity
    {
        String url;
        ChromeDriver driver;
        public OpenUrl(ChromeDriver _driver, string _url)
        {
            url = _url;
           driver = _driver;

        }
        public override void run()
        {


                driver.Navigate().GoToUrl(url);

                //driver.Navigate().GoToUrl("https://www.instagram.com/"

        }
    }
}
