using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Presentation : Form
    {
        public Presentation()
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

        private void lstBoxPodcast_click(object sender, EventArgs e)
        {

            //ta fram alla titlar ur lista episodes för den podcasten som är vald

            if (lstBoxPodcast.SelectedItem != null)
            {
                var pod = lstBoxPodcast.SelectedItem as Podcast;
                

                lstBoxPodcast.DataSource = Podcast.MyProperty
                .Where(items => items == pod)
                .ToList();
                lstBoxEpisode.DisplayMember = "titel";


            }

            //if (lstBoxPodcast.SelectedItem != null)
            //{ 
            //    var pod = lstBoxPodcast.SelectedItem as Podcast;

            //    lstBoxPodcast.DataSource = Podcast.MyProperty
            //    .Where(items => items.Equals(pod))

            //    .ToList();
            //    lstBoxPodcast.DisplayMember = "titel";

            //var Episodes = new Logic.Episode();
            //var newEpisodes = CateList.CateLista();
            //lstBoxCategories.DataSource = newEpisodes;
            //lstBoxCategories.DisplayMember = "titel";

        }
        

        private void lstBoxEpisode_Click(object sender, EventArgs e)
        {

        }

        private void lstBoxEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
