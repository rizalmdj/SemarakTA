using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramDesigner
{
    class OpenUrl : Activity
    {
        public String url;
        public OpenUrl( string _url)
        {
            url = _url;

        }
        public override void run()
        {


            driver.Navigate().GoToUrl(url);

            //driver.Navigate().GoToUrl("https://www.instagram.com/"

        }
    }
}
