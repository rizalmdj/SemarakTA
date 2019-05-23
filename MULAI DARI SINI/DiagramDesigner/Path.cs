using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DiagramDesigner
{
    public class Path
    {
        [XmlAttribute]
        public string ToolTip { get; set; }
        
    }
}
