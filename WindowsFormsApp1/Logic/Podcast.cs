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
        public int UpdateInterval { get; set; }
        public List<Episode> Episodes { get; set; }

        public Podcast()
        {
            this.URL = URL;
            this.Titel = Titel;
            this.Category = Category;
            this.UpdateInterval = UpdateInterval;
            Episodes = new List<Episode>();
        }



        public static List<Podcast> PodList { get; set; } = new List<Podcast>();


    }
}
