using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Banhang
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }

        private void kếtThúcChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmHello();
            toolStripStatusLabel1.Text = "Hello world";
            f.ShowDialog();
            toolStripStatusLabel1.Text = "Ready!";
        }

        private void cộngSốChẵnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmBT1();
            f.ShowDialog();
        }

        private void máyTínhBỏTúiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmMT();
            f.ShowDialog();
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form f = new frmHello();
            f.Show();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void danhMụcHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmDatagrid();
            f.Show();
        }
    }
}
