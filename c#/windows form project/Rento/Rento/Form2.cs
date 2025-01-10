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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("enter your username");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("enter your password");
            }
            else if(textBox3.Text == "")
            {
                MessageBox.Show("repeat password");
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("password error");
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "provider=microsoft.ace.oledb.12.0;data source=rento.accdb";
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "insert into [rento]([username],[password]) values(?,?)";
                cmd.Parameters.AddWithValue("@username",textBox1.Text);
                cmd.Parameters.AddWithValue("@password",textBox3.Text);
                cmd.Connection= con;
                int count=(int)cmd.ExecuteNonQuery();
                if (count > 0) 
                {
                    MessageBox.Show("singup success");
                    con.Close();
                    this.Hide();
                    Rento rento = new Rento();
                    rento.Show();
                }
                else
                {
                    MessageBox.Show("error");
                }

            }
        }
    }
}
