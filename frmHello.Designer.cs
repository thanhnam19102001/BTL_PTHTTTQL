namespace QL_Banhang
{
    partial class frmHello
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
            this.lblHello = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblHello.ForeColor = System.Drawing.Color.Black;
            this.lblHello.Location = new System.Drawing.Point(124, 60);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(0, 36);
            this.lblHello.TabIndex = 0;
            this.lblHello.Click += new System.EventHandler(this.lblHello_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(127, 122);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 40);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            this.btnShow.MouseLeave += new System.EventHandler(this.btnShow_MouseLeave);
            this.btnShow.MouseHover += new System.EventHandler(this.btnShow_MouseHover);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(317, 122);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 40);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            this.btnHide.MouseLeave += new System.EventHandler(this.btnHide_MouseLeave);
            this.btnHide.MouseHover += new System.EventHandler(this.btnHide_MouseHover);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(623, 176);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 40);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(752, 253);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblHello);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHello";
            this.Text = "Hello world";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnOk;
    }
}

