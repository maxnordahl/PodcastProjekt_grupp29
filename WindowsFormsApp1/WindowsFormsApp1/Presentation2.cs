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

        public Presentation2(List<Logic.Category> Cate2)
        {
            InitializeComponent();
            this.Cate2 = Cate2;
        }

        private void Presentation2_Load(object sender, EventArgs e)
        {
            cbBoxPodCate.DataSource = Cate2;
            cbBoxPodCate.DisplayMember = "CateName";

            var updateInterval = new Logic.UpdateInterval();
            var updateIntList = updateInterval.TidLista();
            cbBoxPodUpdate.DataSource = updateIntList;
            cbBoxPodUpdate.DisplayMember = "Tid";

        }

        private void btnPren_Click(object sender, EventArgs e)
        {
            string url = txtBoxURL.Text;
            string name = txtBoxPodName.Text;
            string category = cbBoxPodCate.Text;
            int updateTime = Int32.Parse(cbBoxPodUpdate.Text);

            var newPod = new Logic.Podcast() {URL= url, Titel = name, Category = category, UpdateIntervall = updateTime};
            //newPod.URLtoRSSReader();

            Logic.Podcast.MyProperty.Add(newPod);

            MessageBox.Show("Prenumerationen är skapad");
            this.Close();

        }
    }
}

