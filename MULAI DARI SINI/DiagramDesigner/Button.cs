using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramDesigner
{
    [System.SerializableAttribute()]
    class Button : Activity
    {

        public string xpathButton;
        public Button(string _xpathButton)
        {

            xpathButton = _xpathButton;

        }
        public override void run()
        {

            var button = driver.FindElementByXPath(xpathButton);
            button.Click();

            //Console.WriteLine(xpath + " " + value);
            //driver.Navigate().GoToUrl(url);

            //driver.Navigate().GoToUrl("https://www.instagram.com/"

        }
    }
}
