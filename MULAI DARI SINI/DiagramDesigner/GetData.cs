using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiagramDesigner.Model;

namespace DiagramDesigner
{
    [System.SerializableAttribute()]
    public class GetData : Activity
    {

        public String nama;
        public String xpath;
        public GetData()
        {

        }
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
            DataSingleton.Instance.data.Add(nama, value);

            //driver.Navigate().GoToUrl("https://www.instagram.com/"

        }
    }
}
