using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApplication2
{
    public partial class Boxter : Form
    {
        public Boxter()
        {
            InitializeComponent();
        }

        private void Boxter_Load(object sender, EventArgs e)
        {
        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Porsche porsh = new Porsche();
            porsh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          /* string query1;
            query1 = "select totalsls from besanth_road,brigade,gandhinagar,golkunda,hussain_sagar,kasturba_road,kormangla,lavle,mg_road,mount_road,park_avenue,red_fort_road,salt_lake,sanjay_gandhi_road where carname='Boxter'";
            
            string query2;
            query2 = "select totalsls from besanth_road,brigade,gandhinagar,golkunda,hussain_sagar,kasturba_road,kormangla,lavle,mg_road,mount_road,park_avenue,red_fort_road,salt_lake,sanjay_gandhi_road where carname='911'";
           
            string query3;
            query3 = "select totalsls from besanth_road,brigade,gandhinagar,golkunda,hussain_sagar,kasturba_road,kormangla,lavle,mg_road,mount_road,park_avenue,red_fort_road,salt_lake,sanjay_gandhi_road where carname='panamera'";
            
            string query4;
            query4 = "select totalsls from besanth_road,brigade,gandhinagar,golkunda,hussain_sagar,kasturba_road,kormangla,lavle,mg_road,mount_road,park_avenue,red_fort_road,salt_lake,sanjay_gandhi_road where carname='cayenne'";
            
            string query5;
            query5 = "select totalsls from besanth_road,brigade,gandhinagar,golkunda,hussain_sagar,kasturba_road,kormangla,lavle,mg_road,mount_road,park_avenue,red_fort_road,salt_lake,sanjay_gandhi_road where carname='cayman'";
            
            string query6;
            query6 = "select totalsls from besanth_road,brigade,gandhinagar,golkunda,hussain_sagar,kasturba_road,kormangla,lavle,mg_road,mount_road,park_avenue,red_fort_road,salt_lake,sanjay_gandhi_road where carname='macan'";
           
            chart1.Series["Series1"].Points.AddXY("boxter", query1);

            chart1.Series["Series1"].Points.AddXY("911", query2);

            chart1.Series["Series1"].Points.AddXY("panamera", query3);

            chart1.Series["Series1"].Points.AddXY("cayenne", query4);

            chart1.Series["Series1"].Points.AddXY("cayman", query5);
            chart1.Series["Series1"].Points.AddXY("macan", query6);
            */
            
    
        }
    }
}
