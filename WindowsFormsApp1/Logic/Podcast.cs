using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Podcast
    {
        public string URL { get; set; }
        public string Titel { get; set; }
        public string Category { get; set; }
        public int UpdateIntervall { get; set; }
     

        public Podcast()
        {
            this.URL = URL;
            this.Titel = Titel;
            this.Category = Category;
            this.UpdateIntervall = UpdateIntervall;
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
            newRSS.getFeed();
        }

        public List<Podcast> PodLista()
        {
            var Pods = new List<Podcast>();
            return Pods;
        }

        //foreach (Logic.Podcast enPod in Logic.Pods)
        //{
        //    Console.WriteLine(enPod. + "  " + theGalaxy.MegaLightYears);
        //}

    }
}
