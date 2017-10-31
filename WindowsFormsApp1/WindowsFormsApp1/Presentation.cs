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

        public Inställningar(List<Podcast> MyProperty)
        {
            InitializeComponent();
            this.MyProperty = MyProperty;
        }

        private void btnPren_Click(object sender, EventArgs e)
        {
            Presentation2 presentation2 = new Presentation2(Cate2);
            presentation2.Show();
        }

        List<Category> Cate2 = new List<Category>();

        public List<Podcast> MyProperty { get; }

        public void Presentation_Load(object sender, EventArgs e)

        {
            
                lstBoxCategories.DataSource = Cate2;
                lstBoxCategories.DisplayMember = "CateName";

            

        }

        public void lstBoxCategories_Click_1(object sender, EventArgs e)
        {

            if (lstBoxCategories.SelectedItem != null)
            {
                var category = lstBoxCategories.SelectedItem as Category;

                        lstBoxPodcast.DataSource = Podcast.MyProperty
                    .Where(items => items.Category.Equals(category.CateName))
                    .ToList();
                        lstBoxPodcast.DisplayMember = "Titel";
                    
            }
        }

        private async void lstBoxPodcast_click(object sender, EventArgs e)
        {


            if (lstBoxPodcast.SelectedItem != null)
            {
                Podcast selectedItem = lstBoxPodcast.SelectedItem as Podcast;
                string url = selectedItem.URL;
                var episodeList = await RSSReader.getFeed(url);

                lstBoxEpisode.DataSource = null;
                lstBoxEpisode.DataSource = episodeList;
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
            Presentation3 presentation3 = new Presentation3(Cate2, MyProperty);
            presentation3.Show();
        }
    }
}
