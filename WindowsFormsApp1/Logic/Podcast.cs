using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Podcast
    {
        public string URL { get; set; } = "";
        public string Titel { get; set; } = "";
        public string Category { get; set; }
        public int UpdateIntervall { get; set; }
        public static List<Episode> Episodes { get; set; }

        public Podcast()
        {
            this.URL = URL;
            this.Titel = Titel;
            this.Category = Category;
            this.UpdateIntervall = UpdateIntervall;
            Episodes = new List<Episode>(); ;
        }

        public string getURL()
        {
            return URL;
        }
        public string getTitel()
        {
            return Titel;
        }
        public string getCategory()
        {
            return Category;
        }
        public int getUpdateIntervall()
        {
            return UpdateIntervall;
        }

        public void URLtoRSSReader()
        {
            var newURL = getURL();
            var newRSS = new RSSReader(newURL) ;
            Episodes = newRSS.getFeed();
        }

        public static List<Podcast> MyProperty { get; set; } = new List<Podcast>();


    }
}
