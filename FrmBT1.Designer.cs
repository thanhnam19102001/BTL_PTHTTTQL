namespace QL_Banhang
{
    partial class FrmBT1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính tổng các số chẵn trong n số tự nhiên đầu tiên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "N=";
            // 
            // txtN
            // 
            this.txtN.BackColor = System.Drawing.Color.Plum;
            this.txtN.Location = new System.Drawing.Point(54, 63);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 22);
            this.txtN.TabIndex = 2;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(22, 111);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(44, 17);
            this.lblKQ.TabIndex = 3;
            this.lblKQ.Text = "KQ = ";
            // 
            // btnC1
            // 
            this.btnC1.BackColor = System.Drawing.Color.Plum;
            this.btnC1.Location = new System.Drawing.Point(24, 155);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(75, 47);
            this.btnC1.TabIndex = 4;
            this.btnC1.Text = "Sử dụng for";
            this.btnC1.UseVisualStyleBackColor = false;
            this.btnC1.Click += new System.EventHandler(this.btnC1_Click);
            // 
            // btnC2
            // 
            this.btnC2.BackColor = System.Drawing.Color.Plum;
            this.btnC2.Location = new System.Drawing.Point(132, 155);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(75, 47);
            this.btnC2.TabIndex = 5;
            this.btnC2.Text = "Sử dụng While";
            this.btnC2.UseVisualStyleBackColor = false;
            this.btnC2.Click += new System.EventHandler(this.btnC2_Click);
            // 
            // btnC3
            // 
            this.btnC3.BackColor = System.Drawing.Color.Plum;
            this.btnC3.Location = new System.Drawing.Point(242, 155);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(75, 47);
            this.btnC3.TabIndex = 6;
            this.btnC3.Text = "Sử dụng Do While";
            this.btnC3.UseVisualStyleBackColor = false;
            this.btnC3.Click += new System.EventHandler(this.btnC3_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(265, 218);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Kết thúc";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmBT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(537, 308);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnC3);
            this.Controls.Add(this.btnC2);
            this.Controls.Add(this.btnC1);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBT1";
            this.Text = "frmBT1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button btnExit;
    }
}