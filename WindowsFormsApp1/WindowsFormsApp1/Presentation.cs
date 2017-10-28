﻿using Logic;
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

        public Inställningar()
        {
            InitializeComponent();
        }

        private void btnPren_Click(object sender, EventArgs e)
        {
            Presentation2 presentation2 = new Presentation2();
            presentation2.Show();
        }

        private void Presentation_Load(object sender, EventArgs e)
        {
            {
                var CateList = new Logic.Category();
                var newCateList = CateList.CateLista();
                lstBoxCategories.DataSource = newCateList;
                lstBoxCategories.DisplayMember = "CateName";

            }

        }

        public void txtBoxURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstBoxCategories_Click_1(object sender, EventArgs e)
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
            //    var Pod = lstBoxPodcast.SelectedItem as Titel;
            //{
            //    lstBoxPodcast.DataSource = Podcast.MyProperty
            //    .Where(items => items.Equals(pod))

            //    .ToList();
            //    lstBoxPodcast.DisplayMember = "titel";

            //var Episodes = new Logic.Episode();
            //var newEpisodes = CateList.CateLista();
            //lstBoxCategories.DataSource = newEpisodes;
            //lstBoxCategories.DisplayMember = "titel";

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

        private void lstBoxEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            Presentation3 presentation3 = new Presentation3();
            presentation3.Show();
        }
    }
}
