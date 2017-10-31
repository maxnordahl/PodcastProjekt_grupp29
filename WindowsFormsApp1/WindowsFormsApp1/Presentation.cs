using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Inställningar : Form
    {
        RSSReader RSSReader = new RSSReader();

        public Inställningar(List<Podcast> PodList)
        {
            InitializeComponent();
            this.PodList = PodList;
        }

        private void btnPren_Click(object sender, EventArgs e)
        {
            Presentation2 presentation2 = new Presentation2(Cate2);
            presentation2.Show();
        }

        List<Category> Cate2 = new List<Category>();

        public List<Podcast> PodList { get; }

        public void Presentation_Load(object sender, EventArgs e)

        { 
            lstBoxCategories.DataSource = Cate2;
            lstBoxCategories.DisplayMember = "CateName";

            System.Windows.Forms.Timer timerMin = new System.Windows.Forms.Timer();
            timerMin.Tick += timerMinAsync;
            timerMin.Interval = 60000;
            timerMin.Start();
            System.Windows.Forms.Timer timerHour = new System.Windows.Forms.Timer();
            timerHour.Tick += timerHourAsync;
            timerHour.Interval = 3600000;
            timerHour.Start();
            System.Windows.Forms.Timer timerDay = new System.Windows.Forms.Timer();
            timerDay.Tick += timerDayAsync;
            timerDay.Interval = 216000000;
            timerDay.Start();
        }

       public async void timerMinAsync(object sender, EventArgs e)
        {
            int time = 60000;

            List<Podcast> podList = Podcast.PodList
                 .Where(items => items.UpdateInterval.Equals(time))
                 .ToList();

            if (podList != null)
            {
                foreach (Podcast podcast in podList)
                {
                    string url = podcast.URL;
                    var newEpisodeList = await RSSReader.getFeed(url);
                    podcast.Episodes = newEpisodeList;
                    MessageBox.Show("Podcasten är uppdaterad");
                }
            }
        }

        public async void timerHourAsync(object sender, EventArgs e)
        {
            int time = 3600000;

            List<Podcast> podList = Podcast.PodList
                 .Where(items => items.UpdateInterval.Equals(time))
                 .ToList();

            if (podList != null)
            {
                foreach (Podcast podcast in podList)
                {
                    string url = podcast.URL;
                    var newEpisodeList = await RSSReader.getFeed(url);
                    podcast.Episodes = newEpisodeList;
                    MessageBox.Show("Podcasten är uppdaterad");
                }
            }
        }

        public async void timerDayAsync(object sender, EventArgs e)
        {
            int time = 216000000;

            List<Podcast> podList = Podcast.PodList
                 .Where(items => items.UpdateInterval.Equals(time))
                 .ToList();

            if (podList != null)
            {
                foreach (Podcast podcast in podList)
                {
                    string url = podcast.URL;
                    var newEpisodeList = await RSSReader.getFeed(url);
                    podcast.Episodes = newEpisodeList;
                    MessageBox.Show("Podcasten är uppdaterad");
                }
            }
        }

        public void lstBoxCategories_Click_1(object sender, EventArgs e)
        {

            if (lstBoxCategories.SelectedItem != null)
            {
                var category = lstBoxCategories.SelectedItem as Category;

                        lstBoxPodcast.DataSource = Podcast.PodList
                    .Where(items => items.Category.Equals(category.CateName))
                    .ToList();
                        lstBoxPodcast.DisplayMember = "Titel";
                    
            }
        }

        private void lstBoxPodcast_click(object sender, EventArgs e)
        {


            if (lstBoxPodcast.SelectedItem != null)
            {
                Podcast selectedItem = lstBoxPodcast.SelectedItem as Podcast;
                string url = selectedItem.URL;
                

                lstBoxEpisode.DataSource = null;
                lstBoxEpisode.DataSource = selectedItem.Episodes;
                lstBoxEpisode.DisplayMember = "titel";
            }
        }
        

        private void lstBoxEpisode_DoubleClick(object sender, EventArgs e)
        {
            Episode episodeLink = lstBoxEpisode.SelectedItem as Episode;
            var valdLink = episodeLink.link;
            Episode titel = lstBoxEpisode.SelectedItem as Episode;
            var namn = titel.titel;
            string fileLocation = Environment.CurrentDirectory + namn + ".mp3";
            using (var client = new WebClient())
            {
                lblDownload.Text = "Filen laddas ner...";
                client.DownloadFile(valdLink, fileLocation);
                MessageBox.Show("Filen har nu laddats ner");
            }

                lblDownload.Text = "";  
        }


        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            Episode titel = lstBoxEpisode.SelectedItem as Episode;
            var namn = titel.titel;
            string fileLocation = Environment.CurrentDirectory + namn + ".mp3";
            axWindowsMediaPlayer1.URL = fileLocation;
        }

        private void btnSettings_click(object sender, EventArgs e)
        {
            Presentation3 presentation3 = new Presentation3(Cate2, PodList);
            presentation3.Show();

            presentation3.FormClosed += Presentation3_FormClosed;
        }

        private void Presentation3_FormClosed(object sender, FormClosedEventArgs e)
        {
            lstBoxCategories.DataSource = null;
            lstBoxCategories.DataSource = Cate2;
            lstBoxCategories.DisplayMember = "CateName";
        }

        private void lstBoxEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
