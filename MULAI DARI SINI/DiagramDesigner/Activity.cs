using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DiagramDesigner
{
    [System.SerializableAttribute()]
    [XmlInclude(typeof(OpenUrl))]
    [XmlInclude(typeof(GetData))]
    [XmlInclude(typeof(SetData))]
    [XmlInclude(typeof(Button))]
    public abstract class Activity
    {
        [XmlIgnoreAttribute]
        public ChromeDriver driver;
        abstract public void run();
    }
}
