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
            cbBoxCate.DataSource = cateList;
            cbBoxCate.DisplayMember = "CateName";
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            var category = new Logic.Category();
            Logic.Category x = cbBoxCate.SelectedItem as Logic.Category;
            category.RemoveCateFromList(x);
        }

        private void cbBoxCate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
