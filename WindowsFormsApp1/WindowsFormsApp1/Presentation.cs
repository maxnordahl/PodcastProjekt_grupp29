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
                var newList = CateList.CateLista();
                lstBoxCategories.DataSource = newList;
                lstBoxCategories.DisplayMember = "CateName";
            }
        }
    }
}
