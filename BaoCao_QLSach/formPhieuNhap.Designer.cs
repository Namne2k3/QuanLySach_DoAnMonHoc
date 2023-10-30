namespace BaoCao_QLSach
{
    partial class formPhieuNhap
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
            this.tbTT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNcc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaPN = new System.Windows.Forms.ComboBox();
            this.dtg = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTT
            // 
            this.tbTT.BackColor = System.Drawing.Color.White;
            this.tbTT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTT.Enabled = false;
            this.tbTT.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.tbTT.Location = new System.Drawing.Point(497, 380);
            this.tbTT.Name = "tbTT";
            this.tbTT.ReadOnly = true;
            this.tbTT.Size = new System.Drawing.Size(264, 22);
            this.tbTT.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(299, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng tiền phiếu nhập";
            // 
            // tbNcc
            // 
            this.tbNcc.BackColor = System.Drawing.Color.White;
            this.tbNcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNcc.Enabled = false;
            this.tbNcc.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.tbNcc.Location = new System.Drawing.Point(464, 222);
            this.tbNcc.Name = "tbNcc";
            this.tbNcc.ReadOnly = true;
            this.tbNcc.Size = new System.Drawing.Size(307, 22);
            this.tbNcc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(300, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã nhà cung cấp";
            // 
            // tbDate
            // 
            this.tbDate.BackColor = System.Drawing.Color.White;
            this.tbDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDate.Enabled = false;
            this.tbDate.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.tbDate.Location = new System.Drawing.Point(449, 306);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(322, 22);
            this.tbDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(301, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(299, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // cbMaPN
            // 
            this.cbMaPN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaPN.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaPN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.cbMaPN.FormattingEnabled = true;
            this.cbMaPN.Location = new System.Drawing.Point(449, 152);
            this.cbMaPN.Name = "cbMaPN";
            this.cbMaPN.Size = new System.Drawing.Size(322, 30);
            this.cbMaPN.TabIndex = 1;
            this.cbMaPN.SelectedIndexChanged += new System.EventHandler(this.cbMaPN_SelectedIndexChanged);
            this.cbMaPN.Click += new System.EventHandler(this.cbMaPN_Click);
            // 
            // dtg
            // 
            this.dtg.AllowUserToAddRows = false;
            this.dtg.BackgroundColor = System.Drawing.Color.White;
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colTen,
            this.colTL,
            this.colGM,
            this.colSL,
            this.colTT});
            this.dtg.Location = new System.Drawing.Point(0, 96);
            this.dtg.Name = "dtg";
            this.dtg.RowHeadersVisible = false;
            this.dtg.RowHeadersWidth = 51;
            this.dtg.RowTemplate.Height = 24;
            this.dtg.Size = new System.Drawing.Size(559, 497);
            this.dtg.TabIndex = 0;
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
            // colTL
            // 
            this.colTL.HeaderText = "Thể loại";
            this.colTL.MinimumWidth = 6;
            this.colTL.Name = "colTL";
            this.colTL.ReadOnly = true;
            this.colTL.Width = 125;
            // 
            // colGM
            // 
            this.colGM.HeaderText = "Giá mua";
            this.colGM.MinimumWidth = 6;
            this.colGM.Name = "colGM";
            this.colGM.ReadOnly = true;
            this.colGM.Width = 125;
            // 
            // colSL
            // 
            this.colSL.HeaderText = "Số lượng";
            this.colSL.MinimumWidth = 6;
            this.colSL.Name = "colSL";
            this.colSL.ReadOnly = true;
            this.colSL.Width = 125;
            // 
            // colTT
            // 
            this.colTT.HeaderText = "Thành tiền";
            this.colTT.MinimumWidth = 6;
            this.colTT.Name = "colTT";
            this.colTT.ReadOnly = true;
            this.colTT.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtg);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(800, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 596);
            this.panel1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(181, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 34);
            this.label6.TabIndex = 1;
            this.label6.Text = "Các phiếu nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label7.Location = new System.Drawing.Point(392, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 34);
            this.label7.TabIndex = 2;
            this.label7.Text = "Thông tin phiếu nhập";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(464, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 1);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(464, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 1);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel4.Location = new System.Drawing.Point(497, 408);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 1);
            this.panel4.TabIndex = 14;
            // 
            // formPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1365, 580);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbTT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNcc);
            this.Controls.Add(this.cbMaPN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPhieuNhap";
            this.Text = "formPhieuNhap";
            this.Load += new System.EventHandler(this.formPhieuNhap_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.TextBox tbTT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}