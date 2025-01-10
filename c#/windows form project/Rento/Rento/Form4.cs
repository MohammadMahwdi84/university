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
    public partial class Form4 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter adapter;
        DataTable dt;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ace.oledb.12.0;data source=rento.accdb");
            adapter = new OleDbDataAdapter("select * from rento2", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
        }
    }
}
