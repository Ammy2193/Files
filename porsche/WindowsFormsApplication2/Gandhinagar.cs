﻿using System;
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
    public partial class Gandhinagar : Form
    {
        string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Admin/Documents/admin.accdb";

        OleDbCommand com;
        OleDbDataAdapter oledbda;
        string str;
        DataSet ds;

        public Gandhinagar()
        {
            InitializeComponent();
        }

        private void Gandhinagar_Load(object sender, EventArgs e)
        {
            bindgrid();
        }
        private void bindgrid()
        {
            OleDbConnection con = new OleDbConnection(ConnectionString);
            con.Open();
            str = "select * from gandhinagar";
            com = new OleDbCommand(str, con);
            oledbda = new OleDbDataAdapter(com);
            ds = new DataSet();
            oledbda.Fill(ds, "gandhinagar");
            dataGridView1.DataMember = "gandhinagar";
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
            string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Admin/Documents/admin.accdb";
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into gandhinagar values(" + textBox5.Text + ",'" + textBox1.Text + "','" + textBox4.Text + "'," + textBox2.Text + "," + textBox3.Text + ")";
            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted");
            str = "select * from gandhinagar";
            com = new OleDbCommand(str, con);
            oledbda = new OleDbDataAdapter(com);
            ds = new DataSet();
            oledbda.Fill(ds, "gandhinagar");
            dataGridView1.DataMember = "gandhinagar";
            dataGridView1.DataSource = ds;
            con.Close();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show(" field left blank!!");
            }
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Admin/Documents/admin.accdb";
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete * from gandhinagar where id =" + textBox5.Text + "";
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted");


            str = "select * from gandhinagar";
            com = new OleDbCommand(str, con);
            oledbda = new OleDbDataAdapter(com);
            ds = new DataSet();
            oledbda.Fill(ds, "gandhinagar");
            dataGridView1.DataMember = "gandhinagar";
            dataGridView1.DataSource = ds;

            con.Close();
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Admin/Documents/admin.accdb";
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE gandhinagar SET carname='" + textBox1.Text + "',mnth='" + textBox4.Text + "',totalcrs=" + textBox2.Text + ",totalsls=" + textBox3.Text + " where id=" + textBox5.Text + "";
            cmd.ExecuteNonQuery();
            MessageBox.Show("UPDATED");
            str = "select * from gandhinagar";
            com = new OleDbCommand(str, con);
            oledbda = new OleDbDataAdapter(com);
            ds = new DataSet();
            oledbda.Fill(ds, "gandhinagar");
            dataGridView1.DataMember = "gandhinagar";
            dataGridView1.DataSource = ds;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show(" field left blank!!");
            }
            con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_home ad = new Admin_home();
            ad.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("digits only!");

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("digits only!");

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("digits only!");

            }
        }
    }
}
