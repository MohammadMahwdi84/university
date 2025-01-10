using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rento
{
    public partial class Rento : Form
    {
        public Rento()
        {
            InitializeComponent();
        }

        private void sIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;data source=rento.accdb";
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.CommandText = "select count(*) from[rento] where username=? and password=?";
            com.Parameters.AddWithValue("@username",textBox1.Text);
            com.Parameters.AddWithValue("@password",textBox2.Text);
            com.Connection = con;
            int count=(int)com.ExecuteScalar();
            if (count > 0)
            {
                Properties.Settings.Default.userlog=textBox1.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("welcome");
                con.Close();
                
                Form3 form3 = new Form3();
                this.Hide();
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("not rigester");
            }
        }
    }
}
