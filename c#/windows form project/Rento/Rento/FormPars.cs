using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rento
{
    public partial class FormPars : Form
    {
        public FormPars()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;data source=rento.accdb";
                con.Open();
                OleDbCommand com = new OleDbCommand();
                com.CommandText = "insert into [rento2]([datein],[dateout],[user],[car]) values(?,?,?,?)";
                com.Parameters.AddWithValue("@datein", textBox1.Text);
                com.Parameters.AddWithValue("@dateout", textBox2.Text);
                com.Parameters.AddWithValue("@user",Properties.Settings.Default.userlog);
                com.Parameters.AddWithValue("@car",Properties.Settings.Default.car);

                com.Connection = con;
                int count = (int)com.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("سفارش شما تایید شد");
                    con.Close();
                    Form3 form3 = new Form3();
                    Properties.Settings.Default.car = null;

                    this.Hide();
                    form3.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("شرایط را بپذیرید");
            }
        }
    }
}
