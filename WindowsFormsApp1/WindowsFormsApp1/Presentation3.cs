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
        public Presentation3()
        {
            InitializeComponent();
        }

        private void Presentation3_Load(object sender, EventArgs e)
        {
            var category = new Logic.Category();
            var cateList = category.CateLista();
            cmBoxCateName.DataSource = cateList;
            cmBoxCateName.DisplayMember = "CateName";

            //var pod = new Logic.Podcast();
            //var podList = pod.MyProperty();
            //cmBoxPods.DataSource = podList;
            //cmBoxPods.DisplayMember = "titel";
        }
    }
}
