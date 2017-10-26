using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{

    public class RSSReader
    {
        string url;

        public RSSReader(string url)
        {
            this.url = url;
        }

        public List<Episode> getFeed()
        {

            var EpisodeList = new List<Episode>();

            //Ladda hem XML.
            var xml = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(url);
            }

            //Skapa en objektrepresentation.
            var dom = new System.Xml.XmlDocument();
            dom.LoadXml(xml);

            //Iterera igenom elementet item.
            foreach (System.Xml.XmlNode item in dom.DocumentElement.SelectNodes("channel/item"))
            {
                var newEpisode = new Episode();
                newEpisode.titel = item.SelectSingleNode("title").InnerText;
                newEpisode.pubDate = item.SelectSingleNode("pubDate").InnerText;
                newEpisode.link = item.SelectSingleNode("link").InnerText;
                newEpisode.description = item.SelectSingleNode("description").InnerText;
                EpisodeList.Add(newEpisode);

            }

            return EpisodeList;
        }
    }
}
