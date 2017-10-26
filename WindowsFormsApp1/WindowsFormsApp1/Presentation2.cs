﻿using System;
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
    public partial class Presentation2 : Form
    {
        public Presentation2()
        {
            InitializeComponent();
        }

        private void Presentation2_Load(object sender, EventArgs e)
        {
            var CateList = new Logic.Category();
            var newList = CateList.CateLista();
            cbBoxPodCate.DataSource = newList;
            cbBoxPodCate.DisplayMember = "CateName";
        }
    }
}

