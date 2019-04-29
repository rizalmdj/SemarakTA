using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium.Chrome;

using WpfApp1.Model;

namespace WpfApp1
{
    class GetData : Activity
    {
        MElemet Data;
        ChromeDriver driver;
        public GetData (ChromeDriver _driver, MElemet _mElemet )
        {
            Data = _mElemet;
            driver = _driver;
        }

        public override void run()
        {    
            string value = driver.FindElementByXPath(Data.DivElement).Text;
            Data.PartName = driver.FindElementByXPath(Data.DivElement).Text;
            //Console.WriteLine("Data yang berhasil di ambil nya ");
            //Console.WriteLine(Data.PartName);
            DataSingleton.Instance.data.Add(Data.PartName, Data.PartName);
        }
    }
}
