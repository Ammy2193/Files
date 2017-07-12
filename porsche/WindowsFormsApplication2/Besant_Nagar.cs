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
    public partial class Besant_Nagar : Form
    {
        string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Admin/Documents/admin.accdb";

        OleDbCommand com;
        OleDbDataAdapter oledbda;
        string str;
        DataSet ds;

        public Besant_Nagar()
        {
            InitializeComponent();
        }

        private void Besant_Nagar_Load(object sender, EventArgs e)
        {
            bindgrid();
        }
        private void bindgrid()
        {
            OleDbConnection con = new OleDbConnection(ConnectionString);
            con.Open();
            str = "select * from besanth_road";
            com = new OleDbCommand(str, con);
            oledbda = new OleDbDataAdapter(com);
            ds = new DataSet();
            oledbda.Fill(ds, "besanth_road");
            dataGridView1.DataMember = "besanth_road";
            dataGridView1.DataSource = ds;
            con.Close();
        }
        private void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
               textBox5.Text="";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void hOMEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Admin_home ad = new Admin_home();
            ad.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Admin/Documents/admin.accdb";
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into besanth_road values(" + textBox5.Text + ",'" + textBox1.Text + "','" + textBox4.Text + "'," + textBox2.Text + "," + textBox3.Text + ")";
            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted");

            str = "select * from besanth_road";
            com = new OleDbCommand(str, con);
            oledbda = new OleDbDataAdapter(com);
            ds = new DataSet();
            oledbda.Fill(ds, "besanth_road");
            dataGridView1.DataMember = "besanth_road";
            dataGridView1.DataSource = ds;
            if (textBox1.Text == "" || textBox2.Text == ""|| textBox3.Text==""|| textBox4.Text==""||textBox5.Text=="")
            {
                MessageBox.Show(" field left blank!!");
            }
            con.Close();
            Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Admin/Documents/admin.accdb";
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete * from besanth_road where id =" + textBox5.Text + "";
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted");


            str = "select * from besanth_road";
            com = new OleDbCommand(str, con);
            oledbda = new OleDbDataAdapter(com);
            ds = new DataSet();
            oledbda.Fill(ds, "besanth_road");
            dataGridView1.DataMember = "besanth_road";
            dataGridView1.DataSource = ds;

            con.Close();
            Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Admin/Documents/admin.accdb";
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE besanth_road SET carname='" + textBox1.Text + "',mnth='" + textBox4.Text + "',totalcrs=" + textBox2.Text + ",totalsls=" + textBox3.Text + " where id=" + textBox5.Text + "";
            cmd.ExecuteNonQuery();
            MessageBox.Show("UPDATED");
            str = "select * from besanth_road";
            com = new OleDbCommand(str, con);
            oledbda = new OleDbDataAdapter(com);
            ds = new DataSet();
            oledbda.Fill(ds, "besanth_road");
            dataGridView1.DataMember = "besanth_road";
            dataGridView1.DataSource = ds;
            con.Close();
            Clear();
        }
    }
}
