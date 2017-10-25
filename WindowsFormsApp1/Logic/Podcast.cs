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
        public string ReleaseDate { get; set; }

        private Podcast()
        {
            this.URL = URL;
            this.Titel = Titel;
            this.Category = Category;
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
        public string getReleaseDate()
        {
            return ReleaseDate;
        }

        private static void PodLista()
        {
            var pods = new List<Podcast>
        {
            new Podcast() { URL="", Titel = "", Category = "Favoriter", ReleaseDate = ""}
        };
        }

        //foreach (Logic.Podcast enPod in Logic.Pods)
        //{
        //    Console.WriteLine(enPod. + "  " + theGalaxy.MegaLightYears);
        //}

    }
}
