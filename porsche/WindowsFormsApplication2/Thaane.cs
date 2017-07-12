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
    public partial class Thaane : Form
    {
        string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Admin/Documents/admin.accdb";

        OleDbCommand com;
        OleDbDataAdapter oledbda;
        string str;
        DataSet ds;


        public Thaane()
        {
            InitializeComponent();
        }

        private void INSERT_Click(object sender, EventArgs e)
        {
          

            string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Admin/Documents/admin.accdb";
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into thaane values("+textBox5.Text+",'" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + "," + textBox4.Text + ")";
            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted");

            str = "select * from thaane";
            com = new OleDbCommand(str, con);
            oledbda = new OleDbDataAdapter(com);
            ds = new DataSet();
            oledbda.Fill(ds, "thaane");
            dataGridView1.DataMember = "thaane";
            dataGridView1.DataSource = ds;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show(" field left blank!!");
            }
            con.Close();
            Clear();
        }

        private void Thaane_Load(object sender, EventArgs e)
        {
            bindgrid();
        }
        private void bindgrid()
        {
            OleDbConnection con = new OleDbConnection(ConnectionString);
            con.Open();
            str = "select * from thaane";
            com = new OleDbCommand(str, con);
            oledbda = new OleDbDataAdapter(com);
            ds = new DataSet();
            oledbda.Fill(ds, "thaane");
            dataGridView1.DataMember = "thaane";
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

        private void DELETE_Click(object sender, EventArgs e)
        {
            string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Admin/Documents/admin.accdb";
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete * from thaane where id =" + textBox5.Text + "";
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted");


            str = "select * from thaane";
            com = new OleDbCommand(str, con);
            oledbda = new OleDbDataAdapter(com);
            ds = new DataSet();
            oledbda.Fill(ds, "thaane");
            dataGridView1.DataMember = "thaane";
            dataGridView1.DataSource = ds;

            con.Close();
            Clear();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Admin/Documents/admin.accdb";
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE thaane SET carname='" + textBox1.Text + "',mnth='" + textBox2.Text + "',totalcrs="+textBox3.Text+",totalsls="+textBox4 .Text+" where id="+textBox5 .Text +"";
            cmd.ExecuteNonQuery();
            MessageBox.Show("UPDATED");
            str = "select * from thaane";
            com = new OleDbCommand(str, con);
            oledbda = new OleDbDataAdapter(com);
            ds = new DataSet();
            oledbda.Fill(ds, "thaane");
            dataGridView1.DataMember = "thaane";
            dataGridView1.DataSource = ds;
            con.Close();
            Clear();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_home ad = new Admin_home();
            ad.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("digits only!");
         
            }
           
          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("digits only!");
             
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("digits only!");
         
            }
        }

    }
}
