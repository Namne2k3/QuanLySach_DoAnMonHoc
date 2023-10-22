namespace BaoCao_QLSach
{
    partial class formQuanLySach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNCC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGB = new System.Windows.Forms.TextBox();
            this.tbGM = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtKS = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtKS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTL);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbNCC);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.tbSL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbGB);
            this.groupBox1.Controls.Add(this.tbGM);
            this.groupBox1.Controls.Add(this.tbTen);
            this.groupBox1.Controls.Add(this.tbMa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(258, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 392);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // tbTL
            // 
            this.tbTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTL.Location = new System.Drawing.Point(129, 136);
            this.tbTL.Name = "tbTL";
            this.tbTL.ReadOnly = true;
            this.tbTL.Size = new System.Drawing.Size(187, 22);
            this.tbTL.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Thể loại";
            // 
            // tbNCC
            // 
            this.tbNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNCC.Enabled = false;
            this.tbNCC.Location = new System.Drawing.Point(129, 294);
            this.tbNCC.Name = "tbNCC";
            this.tbNCC.ReadOnly = true;
            this.tbNCC.Size = new System.Drawing.Size(187, 22);
            this.tbNCC.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nhà cung cấp";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(129, 338);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(187, 34);
            this.btDelete.TabIndex = 14;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click_1);
            // 
            // tbSL
            // 
            this.tbSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSL.Enabled = false;
            this.tbSL.Location = new System.Drawing.Point(129, 254);
            this.tbSL.Name = "tbSL";
            this.tbSL.ReadOnly = true;
            this.tbSL.Size = new System.Drawing.Size(187, 22);
            this.tbSL.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lượng";
            // 
            // tbGB
            // 
            this.tbGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGB.Enabled = false;
            this.tbGB.Location = new System.Drawing.Point(129, 217);
            this.tbGB.Name = "tbGB";
            this.tbGB.ReadOnly = true;
            this.tbGB.Size = new System.Drawing.Size(187, 22);
            this.tbGB.TabIndex = 10;
            // 
            // tbGM
            // 
            this.tbGM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGM.Location = new System.Drawing.Point(129, 177);
            this.tbGM.Name = "tbGM";
            this.tbGM.ReadOnly = true;
            this.tbGM.Size = new System.Drawing.Size(187, 22);
            this.tbGM.TabIndex = 9;
            // 
            // tbTen
            // 
            this.tbTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTen.Location = new System.Drawing.Point(129, 94);
            this.tbTen.Name = "tbTen";
            this.tbTen.ReadOnly = true;
            this.tbTen.Size = new System.Drawing.Size(187, 22);
            this.tbTen.TabIndex = 8;
            // 
            // tbMa
            // 
            this.tbMa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMa.Location = new System.Drawing.Point(129, 48);
            this.tbMa.Name = "tbMa";
            this.tbMa.ReadOnly = true;
            this.tbMa.Size = new System.Drawing.Size(187, 22);
            this.tbMa.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giá mua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã sách";
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Location = new System.Drawing.Point(962, 64);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(246, 22);
            this.tbSearch.TabIndex = 11;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(844, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tìm kiếm theo tên";
            // 
            // cbKS
            // 
            this.cbKS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKS.FormattingEnabled = true;
            this.cbKS.Location = new System.Drawing.Point(671, 64);
            this.cbKS.Name = "cbKS";
            this.cbKS.Size = new System.Drawing.Size(130, 24);
            this.cbKS.TabIndex = 9;
            this.cbKS.SelectedIndexChanged += new System.EventHandler(this.cbKS_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kho sách";
            // 
            // dtKS
            // 
            this.dtKS.AllowUserToAddRows = false;
            this.dtKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtKS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colTen,
            this.colTheLoai,
            this.colNcc,
            this.colGM,
            this.colGB,
            this.colSL});
            this.dtKS.Location = new System.Drawing.Point(588, 94);
            this.dtKS.Name = "dtKS";
            this.dtKS.RowHeadersVisible = false;
            this.dtKS.RowHeadersWidth = 51;
            this.dtKS.RowTemplate.Height = 24;
            this.dtKS.Size = new System.Drawing.Size(727, 385);
            this.dtKS.TabIndex = 7;
            this.dtKS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtKS_CellClick);
            // 
            // colMa
            // 
            this.colMa.HeaderText = "Mã sách";
            this.colMa.MinimumWidth = 6;
            this.colMa.Name = "colMa";
            this.colMa.ReadOnly = true;
            this.colMa.Width = 125;
            // 
            // colTen
            // 
            this.colTen.HeaderText = "Tên sách";
            this.colTen.MinimumWidth = 6;
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            this.colTen.Width = 125;
            // 
            // colTheLoai
            // 
            this.colTheLoai.HeaderText = "Thể loại";
            this.colTheLoai.MinimumWidth = 6;
            this.colTheLoai.Name = "colTheLoai";
            this.colTheLoai.ReadOnly = true;
            this.colTheLoai.Width = 125;
            // 
            // colNcc
            // 
            this.colNcc.HeaderText = "Nhà cung cấp";
            this.colNcc.MinimumWidth = 6;
            this.colNcc.Name = "colNcc";
            this.colNcc.ReadOnly = true;
            this.colNcc.Width = 125;
            // 
            // colGM
            // 
            this.colGM.HeaderText = "Giá mua";
            this.colGM.MinimumWidth = 6;
            this.colGM.Name = "colGM";
            this.colGM.ReadOnly = true;
            this.colGM.Width = 125;
            // 
            // colGB
            // 
            this.colGB.HeaderText = "Giá bán";
            this.colGB.MinimumWidth = 6;
            this.colGB.Name = "colGB";
            this.colGB.ReadOnly = true;
            this.colGB.Width = 125;
            // 
            // colSL
            // 
            this.colSL.HeaderText = "Số lượng";
            this.colSL.MinimumWidth = 6;
            this.colSL.Name = "colSL";
            this.colSL.ReadOnly = true;
            this.colSL.Width = 125;
            // 
            // formQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbKS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtKS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formQuanLySach";
            this.Text = "formQuanLySach";
            this.Load += new System.EventHandler(this.formQuanLySach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtKS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNCC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbGB;
        private System.Windows.Forms.TextBox tbGM;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
    }
}