using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace DiagramDesigner
{
    [System.SerializableAttribute()]
    public class Button : Activity
    {

        public string xpathButton;
        public Button()
        {

        }
        public Button(string _xpathButton)
        {

            xpathButton = _xpathButton;

        }
        public override void run()
        {
            try
            {
                var button = driver.FindElementByXPath(xpathButton);
                button.Click();

                //Console.WriteLine(xpath + " " + value);
                //driver.Navigate().GoToUrl(url);

                //driver.Navigate().GoToUrl("https://www.instagram.com/"
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
    }
}
