using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    class Podcast
    {
        public string URL { get; set; }
        public string Titel { get; set; }
        public string Category { get; set; }
        public int UpdateIntervall { get; set; }
        public string ReleaseDate { get; set; }

        private Podcast()
        {
            this.URL = URL;
            this.Titel = Titel;
            this.Category = Category;
            this.UpdateIntervall = UpdateIntervall;
            this.ReleaseDate = ReleaseDate;
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
        public string getReleaseDate()
        {
            return ReleaseDate;
        }

        private static void PodLista()
        {
            var pods = new List<Podcast>
        {
                //new Podcast() { URL="", Titel = "", Category = "", UpdateIntervall = "", ReleaseDate = ""}
            };
        }

        //foreach (Logic.Podcast enPod in Logic.Pods)
        //{
        //    Console.WriteLine(enPod. + "  " + theGalaxy.MegaLightYears);
        //}

    }
}
