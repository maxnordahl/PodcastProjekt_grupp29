using System;
using System.Collections.Generic;

namespace Data
{
    public class RSSReader
    {
        private string name;
        private string url;
        private string description;


        public RSSReader(string url)
        {
            this.url = url;
        }


        public List<FeedItem> GetFeed()
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
    
