namespace BaoCao_QLSach
{
    partial class formGH
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
            this.dg = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btDelete = new System.Windows.Forms.Button();
            this.btPay = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.tbGT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colTen,
            this.colTG,
            this.colGB,
            this.colTL,
            this.colSL,
            this.colMaKS});
            this.dg.Location = new System.Drawing.Point(0, 85);
            this.dg.Name = "dg";
            this.dg.RowHeadersVisible = false;
            this.dg.RowHeadersWidth = 51;
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(649, 406);
            this.dg.TabIndex = 0;
            this.dg.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellEndEdit);
            this.dg.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dg_EditingControlShowing);
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
            // colTG
            // 
            this.colTG.HeaderText = "Tác giả";
            this.colTG.MinimumWidth = 6;
            this.colTG.Name = "colTG";
            this.colTG.ReadOnly = true;
            this.colTG.Width = 125;
            // 
            // colGB
            // 
            this.colGB.HeaderText = "Giá bán";
            this.colGB.MinimumWidth = 6;
            this.colGB.Name = "colGB";
            this.colGB.ReadOnly = true;
            this.colGB.Width = 125;
            // 
            // colTL
            // 
            this.colTL.HeaderText = "Thể loại";
            this.colTL.MinimumWidth = 6;
            this.colTL.Name = "colTL";
            this.colTL.ReadOnly = true;
            this.colTL.Width = 125;
            // 
            // colSL
            // 
            this.colSL.HeaderText = "Số lượng";
            this.colSL.MinimumWidth = 6;
            this.colSL.Name = "colSL";
            this.colSL.Width = 125;
            // 
            // colMaKS
            // 
            this.colMaKS.HeaderText = "Mã kho sách";
            this.colMaKS.MinimumWidth = 6;
            this.colMaKS.Name = "colMaKS";
            this.colMaKS.ReadOnly = true;
            this.colMaKS.Width = 125;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btDelete.FlatAppearance.BorderSize = 0;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(853, 254);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(193, 45);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Xóa khỏi giỏ hàng";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btPay
            // 
            this.btPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btPay.FlatAppearance.BorderSize = 0;
            this.btPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPay.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPay.ForeColor = System.Drawing.Color.White;
            this.btPay.Location = new System.Drawing.Point(675, 254);
            this.btPay.Name = "btPay";
            this.btPay.Size = new System.Drawing.Size(158, 45);
            this.btPay.TabIndex = 2;
            this.btPay.Text = "Đặt Hàng";
            this.btPay.UseVisualStyleBackColor = false;
            this.btPay.Click += new System.EventHandler(this.btPay_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btSubmit.FlatAppearance.BorderSize = 0;
            this.btSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubmit.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmit.ForeColor = System.Drawing.Color.White;
            this.btSubmit.Location = new System.Drawing.Point(675, 338);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(371, 45);
            this.btSubmit.TabIndex = 3;
            this.btSubmit.Text = "Xác nhận thanh toán";
            this.btSubmit.UseVisualStyleBackColor = false;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // tbGT
            // 
            this.tbGT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGT.Enabled = false;
            this.tbGT.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGT.Location = new System.Drawing.Point(774, 160);
            this.tbGT.Name = "tbGT";
            this.tbGT.Size = new System.Drawing.Size(272, 22);
            this.tbGT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(671, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thành tiền";
            // 
            // tbSL
            // 
            this.tbSL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSL.Enabled = false;
            this.tbSL.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSL.Location = new System.Drawing.Point(774, 102);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(272, 22);
            this.tbSL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(670, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng sách:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dg);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 494);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(255, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giỏ hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(771, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thanh toán";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(774, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 1);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(774, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 1);
            this.panel3.TabIndex = 12;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Location = new System.Drawing.Point(943, 407);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(103, 43);
            this.btExit.TabIndex = 13;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // formGH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1074, 480);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.btPay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formGH";
            this.Text = "Giỏ hàng";
            this.Load += new System.EventHandler(this.formGH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.TextBox tbGT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPay;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKS;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btExit;
    }
}