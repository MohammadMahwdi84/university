using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rento
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormBenz benz = new FormBenz();
            Properties.Settings.Default.car = "benz";
            this.Hide();
            benz.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormSan san = new FormSan();
            Properties.Settings.Default.car = "sonata";

            this.Hide();
            san.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormPars pars = new FormPars();
            Properties.Settings.Default.car = "pars";

            this.Hide();
            pars.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form207 form207 = new Form207();
            Properties.Settings.Default.car = "pejo207";

            this.Hide();    
            form207.Show();
        }

        private void مشاهدهسفارشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }
    }
}
