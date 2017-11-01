using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Presentation2 : Form
    {
        public List<Logic.Category> Cate2 { get; }
        public Logic.RSSReader RSSReader = new Logic.RSSReader();

        public Presentation2(List<Logic.Category> Cate2)
        {
            InitializeComponent();
            this.Cate2 = Cate2;
        }


        private void Presentation2_Load(object sender, EventArgs e)
        {
            cbBoxPodCate.DataSource = Cate2;
            cbBoxPodCate.DisplayMember = "CateName";

        }


        private async void btnPren_Click(object sender, EventArgs e)
        {
            string url = txtBoxURL.Text;
            string name = txtBoxPodName.Text;
            string category = cbBoxPodCate.Text;

            var chosenUpdate = cbBoxPodUpdate.SelectedItem;
            string chosenUpdateString = chosenUpdate.ToString().Replace("Varje minut", "60000").Replace("Varje timme", "3600000").Replace("Varje dag", "216000000");
            int updateInterval = int.Parse(chosenUpdateString);

            var episodeList = await RSSReader.getFeed(url);


            var newPod = new Logic.Podcast() {URL= url, Titel = name, Category = category, UpdateInterval = updateInterval, Episodes = episodeList};
            //newPod.URLtoRSSReader();

            Logic.Podcast.PodList.Add(newPod);

            MessageBox.Show("Prenumerationen är skapad");
            this.Close();

        }
    }
}

