
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
    }
}
