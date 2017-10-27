using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{

    public class RSSReader
    {
        
      
        public async Task<List<Episode>> getFeed(string url)
        {

            var EpisodeList = new List<Episode>();

            //Ladda hem XML.
            var xml = "";
            var feedOfPodcasts = new List<Episode>();
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                await Task.Run(() => xml = client.DownloadString(url));
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
