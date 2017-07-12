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
    public partial class Admin_home : Form
    {
        public Admin_home()
        {
            InitializeComponent();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_login al = new Admin_login();
            al.Show();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_home ad = new Admin_home();
            ad.Show();
        }

        private void lAVLEROADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LAVLEROAD l = new LAVLEROAD();
            l.Show();
        }

        private void bRIGADEROADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brigade bri = new Brigade();
            bri.Show();
        }

        private void kORMANGLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kormangla k = new Kormangla();
            k.Show();
        }

        private void gOLKONDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Golkonda go = new Golkonda();
            go.Show();
        }

        private void hUSSAINSAGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hassin_sagar has = new Hassin_sagar();
            has.Show();
        }

        private void tHAANEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thaane t = new Thaane();
            t.Show();
        }

        private void sANJAYGANDHIROADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sanjay_Gandhi_Road san = new Sanjay_Gandhi_Road();
            san.Show();
        }

        private void rEDFORTROADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Red_Fort_Road red = new Red_Fort_Road();
            red.Show();
        }

        private void mGROADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MG_Road mg = new MG_Road();
            mg.Show();
        }

        private void mOUNTROADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mount_Road mou = new Mount_Road();
            mou.Show();

        }

        private void bESANTNAGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Besant_Nagar bes = new Besant_Nagar();
            bes.Show();
        }

        private void pARKAVENUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Park_Avenue par = new Park_Avenue();
            par.Show();
        }

        private void sALTLAKEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salt_Lake sal = new Salt_Lake();
            sal.Show();
        }

        private void gANDHINAGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gandhinagar gan = new Gandhinagar();
            gan.Show();
        }

        private void kASTURBAROADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kasturba_Road kas = new Kasturba_Road();
            kas.Show();
        }

        private void pORSCHEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Porsche por = new Porsche();
            por.Show();
        }

        private void Admin_home_Load(object sender, EventArgs e)
        {

        }
    }
}
