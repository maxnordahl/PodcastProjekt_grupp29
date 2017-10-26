using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Data
{
    public class RssReader
    {
        private string name;
        private string url;
        private string description;


        public RssReader(string url)
        {
            this.url = url;
        }


        public void GetFeed()
        {
            //Ladda hem XML.
            var xml = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString("http://www.aftonbladet.se/rss.xml");
            }

            //Skapa en objektrepresentation.
            var dom = new System.Xml.XmlDocument();
            dom.LoadXml(xml);

            //Iterera igenom elementet item.
            foreach (System.Xml.XmlNode item
               in dom.DocumentElement.SelectNodes("channel/item"))
            {
                //Skriv ut dess titel.
                var title = item.SelectSingleNode("title");
                Console.WriteLine(title.InnerText);
            }


        }
    }
}
    
