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
    public partial class frmDatagrid : Form
    {
        public frmDatagrid()
        {
            InitializeComponent();
        }

        private void frmDatagrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlbhDataSet.tblDMHH' table. You can move, or remove it, as needed.
            this.tblDMHHTableAdapter.Fill(this.qlbhDataSet.tblDMHH);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tblDMHHBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tblDMHHBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tblDMHHBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tblDMHHBindingSource.MoveLast();
        }
    }
}
