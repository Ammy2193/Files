﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Macan : Form
    {
        public Macan()
        {
            InitializeComponent();
        }

        private void Macan_Load(object sender, EventArgs e)
        {
            
            
        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Porsche porsh = new Porsche();
            porsh.Show();
        }
    }
}
