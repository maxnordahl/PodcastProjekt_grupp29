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

        public List<Logic.Podcast> MyProperty { get; }

        public Presentation3(List<Logic.Category> Cate2, List<Logic.Podcast> MyProperty)
        {
            InitializeComponent();
            this.Cate2 = Cate2;
            this.MyProperty = MyProperty;
        }

        private void Presentation3_Load(object sender, EventArgs e)
        {
            cmBoxCateName.DataSource = Cate2;
            cmBoxCateName.DisplayMember = "CateName";

            cmBoxPods.DataSource = MyProperty;
            cmBoxPods.DisplayMember = "titel";

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

            //updatera Presentation
        }
    }
}
