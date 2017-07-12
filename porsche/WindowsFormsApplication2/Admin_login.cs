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
    public partial class Admin_login : Form
    { 
       OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Admin/Documents/admin.accdb");
        public Admin_login()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            string a = "amrita";
            string b = "akshay";
            string name = textBox1.Text;
            string pass = textBox2.Text;
            if (a == name & b == pass)
            {
                MessageBox.Show("successfull login");
                Admin_home f4 = new Admin_home();
                f4.Show();
            }
            else if (a != name)
            {
                MessageBox.Show("Invalid username");
            }
            else if (b != pass)
            {
                MessageBox.Show("Invalid password");
            }
            
          
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(" Field left blank!!");
            }
            con.Close();
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {

        }
    }
}
