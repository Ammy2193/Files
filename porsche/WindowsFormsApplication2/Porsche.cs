using System;
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
    public partial class Porsche : Form
    {
        public Porsche()
        {
            InitializeComponent();
        }

        private void Porsche_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Macan mac = new Macan();
            mac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cayenne cay = new Cayenne();
            cay.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panamera pan = new Panamera();
            pan.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cayman ca = new Cayman();
            ca.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pors po = new Pors();
            po.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Boxter box = new Boxter();
            box.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_home ad = new Admin_home();
            ad.Show();
        }
    }
}
