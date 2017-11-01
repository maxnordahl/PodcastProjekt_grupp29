
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
    public partial class Presentation3 : Form
    {
        private readonly List<Logic.Category> Cate2;

        public Presentation3(List<Logic.Category> Cate2, List<Logic.Podcast> PodList)
        {
            InitializeComponent();
            this.Cate2 = Cate2;
            this.PodList = PodList;
        }

        public List<Logic.Podcast> PodList { get; }

        private void Presentation3_Load(object sender, EventArgs e)
        {
            cmBoxCateName.DataSource = Cate2;
            cmBoxCateName.DisplayMember = "CateName";

            cmBoxCateName2.DataSource = Cate2;
            cmBoxCateName2.DisplayMember = "CateName";

            cmBoxPods.DataSource = null;
            cmBoxPods.DataSource = PodList;
            cmBoxPods.DisplayMember = "Titel";


        }

        private void btnRemoveCate_Click(object sender, EventArgs e)
        {
            string CateName = cmBoxCateName.Text;
            Cate2.Remove(cmBoxCateName.SelectedItem as Logic.Category);
            MessageBox.Show("Kategorin " + CateName + " har tagits bort.");

        }

        private void btnNewCate_Click(object sender, EventArgs e)
        {
            var newCate = new Logic.Category(txtBoxNewCateName2.Text);

            Cate2.Add(newCate as Logic.Category);
            MessageBox.Show("Kategorin " + newCate.CateName + " har lagts till.");

            cmBoxCateName.DataSource = null;
            cmBoxCateName.DataSource = Cate2;
            cmBoxCateName.DisplayMember = "CateName";
        }

        private void btnRemovePod_Click(object sender, EventArgs e)
        {
            string PodName = cmBoxPods.Text;
            PodList.Remove(cmBoxPods.SelectedItem as Logic.Podcast);
            MessageBox.Show("Podcast" + PodList + "har tagits bort.");

            cmBoxPods.DataSource = null;
            cmBoxPods.DataSource = PodList;
            cmBoxPods.DisplayMember = "Titel";
        }

        private void btnChangeCateName_Click(object sender, EventArgs e)
        {

            var cateObject = cmBoxCateName.SelectedItem as Logic.Category;
            var oldCateName = cateObject.CateName;

            string newCateName = txtBoxNewName.Text;

            cateObject.CateName = newCateName;

            MessageBox.Show("Kategorinamnet " + oldCateName + " har ändrats till " + newCateName);

            cmBoxCateName.DataSource = null;
            cmBoxCateName.DataSource = Cate2;
            cmBoxCateName.DisplayMember = "CateName";
        }

        private async void btnChangeURL_Click(object sender, EventArgs e)
        {
            var oldPod = cmBoxPods.SelectedItem as Logic.Podcast;
            string newURL = txtBoxNewURL.Text;

            oldPod.URL = newURL;

            MessageBox.Show("URL för Podcast " + oldPod.Titel + " har ändrats");

            Logic.RSSReader reader = new Logic.RSSReader();
            var newEpisodeList = await reader.getFeed(newURL);

            oldPod.Episodes = newEpisodeList;

            cmBoxPods.DataSource = null;
            cmBoxPods.DataSource = PodList;
            cmBoxPods.DisplayMember = "Titel";
        }

        private void btnChangeIntervalPod_Click(object sender, EventArgs e)
        {

            var pod = cmBoxPods.SelectedItem as Logic.Podcast;
            var chosenUpdate = cmBoxNewInterval.SelectedItem;
            string chosenUpdateString = chosenUpdate.ToString().Replace("Varje minut", "60000").Replace("Varje timme", "3600000").Replace("Varje dag", "216000000");
            int updateInterval = int.Parse(chosenUpdateString);

            pod.UpdateInterval = updateInterval;

            MessageBox.Show("Uppdateringsintervallen är ändrad till " + cmBoxPods.Text);

        }

        private void btnChangePodName_Click(object sender, EventArgs e)
        {
            var newName = txtBoxNewPodName.Text;

            var podObject = cmBoxPods.SelectedItem as Logic.Podcast;
            var oldName = podObject.Titel;

            podObject.Titel = newName;

            MessageBox.Show("Podcastnamnet " + oldName + " har ändrats till " + newName);

            cmBoxPods.DataSource = null;
            cmBoxPods.DataSource = PodList;
            cmBoxPods.DisplayMember = "Titel";
        }
    }
}
