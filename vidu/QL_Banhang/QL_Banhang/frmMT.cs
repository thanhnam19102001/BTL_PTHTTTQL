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
    public partial class frmMT : Form
    {
        public frmMT()
        {
            InitializeComponent();
        }
        float data1, data2;
        string pheptinh; 
        private void button10_Click(object sender, EventArgs e)
        {
            txtHT1.Text = txtHT1.Text + "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtHT1.Text = txtHT1.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtHT1.Text = txtHT1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtHT1.Text = txtHT1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtHT1.Text = txtHT1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtHT1.Text = txtHT1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtHT1.Text = txtHT1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHT1.Text = txtHT1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHT1.Text = txtHT1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtHT1.Text = txtHT1.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtHT1.Text = txtHT1.Text + ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtHT1.Clear();
            txtHT2.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (pheptinh == "cong")
            {
                data2 = data1 + float.Parse(txtHT1.Text);
                txtHT2.Text = data1.ToString() + " + " + float.Parse(txtHT1.Text) ;
                txtHT1.Text = data2.ToString();
            }
            if (pheptinh == "tru")
            {
                data2 = data1 - float.Parse(txtHT1.Text);
                txtHT2.Text = data1.ToString() + " - " + float.Parse(txtHT1.Text) ;
                txtHT1.Text = data2.ToString();
            }
            if (pheptinh == "nhan")
            {
                data2 = data1 * float.Parse(txtHT1.Text);
                txtHT2.Text = data1.ToString() + " * " + float.Parse(txtHT1.Text) ;
                txtHT1.Text = data2.ToString();
            }
            if (pheptinh == "chia")
            {
                if (float.Parse(txtHT1.Text) == 0)
                {
                    txtHT1.Text = "khong chia duoc";
                }
                else
                {

                    data2 = data1 / float.Parse(txtHT1.Text);
                    txtHT2.Text = data1.ToString() + " / ";
                    txtHT1.Text = data2.ToString();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";
            txtHT2.Text = data1.ToString() + "-";
            data1 = float.Parse(txtHT1.Text);
           
           
            txtHT1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pheptinh = "nhan";
            txtHT2.Text = data1.ToString() + "*";
            data1 = float.Parse(txtHT1.Text);
            
            txtHT1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pheptinh = "chia";
            txtHT2.Text = data1.ToString() + "/";
            data1 = float.Parse(txtHT1.Text);
            
            txtHT1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pheptinh = "cong";
            txtHT2.Text = data1.ToString() + "+";
            data1 = float.Parse(txtHT1.Text);
            
            txtHT1.Clear();

        }
    }
}
