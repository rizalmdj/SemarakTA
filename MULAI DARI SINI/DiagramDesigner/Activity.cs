using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramDesigner
{
    public abstract class Activity
    {
        public ChromeDriver driver;
        abstract public void run();
    }
}
