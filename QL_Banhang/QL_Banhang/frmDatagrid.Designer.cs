﻿namespace QL_Banhang
{
    partial class frmDatagrid
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qlbhDataSet = new QL_Banhang.qlbhDataSet();
            this.tblDMHHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDMHHTableAdapter = new QL_Banhang.qlbhDataSetTableAdapters.tblDMHHTableAdapter();
            this.maNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGvndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGusdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDMHHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhomDataGridViewTextBoxColumn,
            this.maHHDataGridViewTextBoxColumn,
            this.tenHHDataGridViewTextBoxColumn,
            this.dvtDataGridViewTextBoxColumn,
            this.sanXuatDataGridViewTextBoxColumn,
            this.dGvndDataGridViewTextBoxColumn,
            this.dGusdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDMHHBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(396, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // qlbhDataSet
            // 
            this.qlbhDataSet.DataSetName = "qlbhDataSet";
            this.qlbhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDMHHBindingSource
            // 
            this.tblDMHHBindingSource.DataMember = "tblDMHH";
            this.tblDMHHBindingSource.DataSource = this.qlbhDataSet;
            // 
            // tblDMHHTableAdapter
            // 
            this.tblDMHHTableAdapter.ClearBeforeFill = true;
            // 
            // maNhomDataGridViewTextBoxColumn
            // 
            this.maNhomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maNhomDataGridViewTextBoxColumn.DataPropertyName = "MaNhom";
            this.maNhomDataGridViewTextBoxColumn.HeaderText = "Mã nhóm";
            this.maNhomDataGridViewTextBoxColumn.Name = "maNhomDataGridViewTextBoxColumn";
            this.maNhomDataGridViewTextBoxColumn.Width = 95;
            // 
            // maHHDataGridViewTextBoxColumn
            // 
            this.maHHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maHHDataGridViewTextBoxColumn.DataPropertyName = "MaHH";
            this.maHHDataGridViewTextBoxColumn.HeaderText = "Mã hàng";
            this.maHHDataGridViewTextBoxColumn.Name = "maHHDataGridViewTextBoxColumn";
            this.maHHDataGridViewTextBoxColumn.Width = 92;
            // 
            // tenHHDataGridViewTextBoxColumn
            // 
            this.tenHHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tenHHDataGridViewTextBoxColumn.DataPropertyName = "TenHH";
            this.tenHHDataGridViewTextBoxColumn.HeaderText = "Tên hàng";
            this.tenHHDataGridViewTextBoxColumn.Name = "tenHHDataGridViewTextBoxColumn";
            this.tenHHDataGridViewTextBoxColumn.Width = 98;
            // 
            // dvtDataGridViewTextBoxColumn
            // 
            this.dvtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dvtDataGridViewTextBoxColumn.DataPropertyName = "Dvt";
            this.dvtDataGridViewTextBoxColumn.HeaderText = "Đvt";
            this.dvtDataGridViewTextBoxColumn.Name = "dvtDataGridViewTextBoxColumn";
            this.dvtDataGridViewTextBoxColumn.Width = 58;
            // 
            // sanXuatDataGridViewTextBoxColumn
            // 
            this.sanXuatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sanXuatDataGridViewTextBoxColumn.DataPropertyName = "SanXuat";
            this.sanXuatDataGridViewTextBoxColumn.HeaderText = "Nước SX";
            this.sanXuatDataGridViewTextBoxColumn.Name = "sanXuatDataGridViewTextBoxColumn";
            this.sanXuatDataGridViewTextBoxColumn.Width = 92;
            // 
            // dGvndDataGridViewTextBoxColumn
            // 
            this.dGvndDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dGvndDataGridViewTextBoxColumn.DataPropertyName = "DGvnd";
            this.dGvndDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.dGvndDataGridViewTextBoxColumn.Name = "dGvndDataGridViewTextBoxColumn";
            this.dGvndDataGridViewTextBoxColumn.Width = 86;
            // 
            // dGusdDataGridViewTextBoxColumn
            // 
            this.dGusdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dGusdDataGridViewTextBoxColumn.DataPropertyName = "DGusd";
            this.dGusdDataGridViewTextBoxColumn.HeaderText = "DGusd";
            this.dGusdDataGridViewTextBoxColumn.Name = "dGusdDataGridViewTextBoxColumn";
            this.dGusdDataGridViewTextBoxColumn.Width = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "ĐVT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nước SX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "ĐƠn giá usd";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDMHHBindingSource, "MaNhom", true));
            this.textBox1.Location = new System.Drawing.Point(556, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDMHHBindingSource, "MaHH", true));
            this.textBox2.Location = new System.Drawing.Point(556, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDMHHBindingSource, "TenHH", true));
            this.textBox3.Location = new System.Drawing.Point(556, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDMHHBindingSource, "Dvt", true));
            this.textBox4.Location = new System.Drawing.Point(556, 135);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDMHHBindingSource, "SanXuat", true));
            this.textBox5.Location = new System.Drawing.Point(556, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDMHHBindingSource, "DGvnd", true));
            this.textBox6.Location = new System.Drawing.Point(556, 198);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDMHHBindingSource, "DGusd", true));
            this.textBox7.Location = new System.Drawing.Point(556, 226);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Đầu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Trước";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Sau";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(329, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 26);
            this.button4.TabIndex = 18;
            this.button4.Text = "Cuối";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(556, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Kết thúc";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDatagrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 301);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDatagrid";
            this.Text = "frmDatagrid";
            this.Load += new System.EventHandler(this.frmDatagrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDMHHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private qlbhDataSet qlbhDataSet;
        private System.Windows.Forms.BindingSource tblDMHHBindingSource;
        private qlbhDataSetTableAdapters.tblDMHHTableAdapter tblDMHHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGvndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGusdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnExit;
    }
}