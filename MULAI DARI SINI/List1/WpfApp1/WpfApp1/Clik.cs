using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using WpfApp1.Model;

namespace WpfApp1
{
    class Clik : Activity
    {
        MElemet Data;
        ChromeDriver driver;
        public Clik(ChromeDriver _driver, MElemet _mElemet)
        {
            Data = _mElemet;
            driver = _driver;
        }

        public override void run()
        {
            driver.FindElement(By.XPath(Data.DivElement)).Click();
        }
    }
}
