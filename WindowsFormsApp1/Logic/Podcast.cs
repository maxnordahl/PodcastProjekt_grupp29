using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Logic
{
    [Serializable]
    public class Podcast
    {
        [XmlElement("Url")]
        public string URL { get; set; } = "";
        [XmlElement("Titel")]
        public string Titel { get; set; } = "";
        [XmlElement("Category")]
        public string Category { get; set; }
        [XmlElement("Updateinterval")]
        public int UpdateInterval { get; set; }
        [XmlArray("Episode list"), XmlArrayItem(typeof(Episode))]
        public List<Episode> Episodes { get; set; }

        public Podcast()
        {
            this.URL = URL;
            this.Titel = Titel;
            this.Category = Category;
            this.UpdateInterval = UpdateInterval;
            Episodes = new List<Episode>();
        }

        [XmlArray("Podcast list"), XmlArrayItem(typeof(Podcast))]
        public static List<Podcast> PodList { get; set; } = new List<Podcast>();


    }
}
