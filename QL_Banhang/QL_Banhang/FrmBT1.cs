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
    public partial class FrmBT1 : Form

    {
        int i, n, t;
        public FrmBT1()
        {
            InitializeComponent();
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            t = 0;
            while (n%2 == 0)
            {
                t = t + n;
            }
            lblKQ.Text = "Tổng các số chẵn trong " + txtN.Text + " số tự nhiên đầu tiên tính theo cách 2 là: " + Convert.ToString(t);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            t = 0;
            for (i=0;i<=n;i+=2)
            {
                t = t + i;
            }
            lblKQ.Text = "Tổng các số chẵn trong " + txtN.Text + " số tự nhiên đầu tiên tính theo cách 1 là: " + Convert.ToString(t);
        }
    }
}
