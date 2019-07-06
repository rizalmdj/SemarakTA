using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

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
            try
            {
                driver.FindElementByXPath(xpath).SendKeys(content);
                //Console.WriteLine(xpath + " " + value);
                //driver.Navigate().GoToUrl(url);

                //driver.Navigate().GoToUrl("https://www.instagram.com/"
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }


        }
    }
}
