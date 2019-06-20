using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramDesigner
{
    [System.SerializableAttribute()]
    public class SetData : Activity
    {
        public string xpath;
        public string content;
        public SetData()
        {

        }
        public SetData(string _xpath, string _content)
        {
         
            xpath = _xpath;
            content = _content;

        }
        public override void run()
        {

            driver.FindElementByXPath(xpath).SendKeys(content);
            //Console.WriteLine(xpath + " " + value);
            //driver.Navigate().GoToUrl(url);

            //driver.Navigate().GoToUrl("https://www.instagram.com/"

        }
    }
}
