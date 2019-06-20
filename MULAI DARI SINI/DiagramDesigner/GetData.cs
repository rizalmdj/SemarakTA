using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramDesigner
{
    [System.SerializableAttribute()]
    class GetData : Activity
    {
        public String nama;
        public string xpath;
        public GetData(string _nama, string _xpath)
        {
            nama = _nama;
            xpath = _xpath;

        }
        public override void run()
        {

            string value = driver.FindElementByXPath(xpath).Text;
            Console.WriteLine(nama + " " + value);
            //driver.Navigate().GoToUrl(url);

            //driver.Navigate().GoToUrl("https://www.instagram.com/"

        }
    }
}
