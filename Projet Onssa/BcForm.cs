﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Onssa
{
    public partial class BcForm : Form
    {
        public BcForm()
        {
            InitializeComponent();
        }

        private void BcForm_Load(object sender, EventArgs e)
        {
            
        }

        private void viderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.vider(this);
        }
    }
}