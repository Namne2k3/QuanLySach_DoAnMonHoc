namespace BaoCao_QLSach
{
    partial class formNhapSach
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
            this.dtg = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbNcc = new System.Windows.Forms.ComboBox();
            this.btImport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTT = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg
            // 
            this.dtg.AllowUserToAddRows = false;
            this.dtg.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colTen,
            this.colGM,
            this.colTL,
            this.colCS,
            this.colSL});
            this.dtg.Location = new System.Drawing.Point(619, 88);
            this.dtg.Name = "dtg";
            this.dtg.RowHeadersVisible = false;
            this.dtg.RowHeadersWidth = 51;
            this.dtg.RowTemplate.Height = 24;
            this.dtg.Size = new System.Drawing.Size(711, 426);
            this.dtg.TabIndex = 0;
            this.dtg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CellClick);
            this.dtg.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtg_EditingControlShowing);
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
            // colGM
            // 
            this.colGM.HeaderText = "Giá mua";
            this.colGM.MinimumWidth = 6;
            this.colGM.Name = "colGM";
            this.colGM.ReadOnly = true;
            this.colGM.Width = 125;
            // 
            // colTL
            // 
            this.colTL.HeaderText = "Thể loại";
            this.colTL.MinimumWidth = 6;
            this.colTL.Name = "colTL";
            this.colTL.ReadOnly = true;
            this.colTL.Width = 125;
            // 
            // colCS
            // 
            this.colCS.HeaderText = "Có sẵn";
            this.colCS.MinimumWidth = 6;
            this.colCS.Name = "colCS";
            this.colCS.ReadOnly = true;
            this.colCS.Width = 125;
            // 
            // colSL
            // 
            this.colSL.HeaderText = "Cần nhập SL";
            this.colSL.MinimumWidth = 6;
            this.colSL.Name = "colSL";
            this.colSL.Width = 125;
            // 
            // cbNcc
            // 
            this.cbNcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNcc.FormattingEnabled = true;
            this.cbNcc.Location = new System.Drawing.Point(30, 150);
            this.cbNcc.Name = "cbNcc";
            this.cbNcc.Size = new System.Drawing.Size(248, 26);
            this.cbNcc.TabIndex = 1;
            this.cbNcc.SelectedIndexChanged += new System.EventHandler(this.cbNcc_SelectedIndexChanged);
            // 
            // btImport
            // 
            this.btImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btImport.FlatAppearance.BorderSize = 0;
            this.btImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImport.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImport.ForeColor = System.Drawing.Color.White;
            this.btImport.Location = new System.Drawing.Point(30, 343);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(248, 43);
            this.btImport.TabIndex = 3;
            this.btImport.Text = "Nhập sách";
            this.btImport.UseVisualStyleBackColor = false;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.cbKS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbTT);
            this.groupBox1.Controls.Add(this.cbNcc);
            this.groupBox1.Controls.Add(this.btImport);
            this.groupBox1.Controls.Add(this.tbDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.groupBox1.Location = new System.Drawing.Point(285, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 434);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // cbKS
            // 
            this.cbKS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKS.FormattingEnabled = true;
            this.cbKS.Location = new System.Drawing.Point(30, 213);
            this.cbKS.Name = "cbKS";
            this.cbKS.Size = new System.Drawing.Size(248, 26);
            this.cbKS.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kho sách cần nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nhà cung cấp";
            // 
            // tbTT
            // 
            this.tbTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTT.Location = new System.Drawing.Point(30, 278);
            this.tbTT.Name = "tbTT";
            this.tbTT.ReadOnly = true;
            this.tbTT.Size = new System.Drawing.Size(248, 24);
            this.tbTT.TabIndex = 5;
            // 
            // tbDate
            // 
            this.tbDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDate.Location = new System.Drawing.Point(30, 88);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(248, 24);
            this.tbDate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thành tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày hiện tại";
            // 
            // formNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1426, 584);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formNhapSach";
            this.Text = "formNhapSach";
            this.Load += new System.EventHandler(this.formNhapSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.ComboBox cbNcc;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTT;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.ComboBox cbKS;
        private System.Windows.Forms.Label label1;
    }
}