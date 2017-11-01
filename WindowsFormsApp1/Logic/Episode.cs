using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Logic
{
    [Serializable]
    public class Episode
    {
        [XmlElement ("Titel")]
        public string titel { get; set; } 
        [XmlElement("Datum")]
        public string pubDate { get; set; }
        [XmlElement("Link")]
        public string link { get; set; }
        [XmlElement("Description")]
        public string description { get; set; }

    }

}
