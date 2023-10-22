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
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btPay = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.tbGT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colTen,
            this.colTG,
            this.colGB,
            this.colTL,
            this.colSL,
            this.colMaKS});
            this.dg.Location = new System.Drawing.Point(12, 12);
            this.dg.Name = "dg";
            this.dg.RowHeadersVisible = false;
            this.dg.RowHeadersWidth = 51;
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(597, 256);
            this.dg.TabIndex = 0;
            this.dg.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellEndEdit);
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
            // groupbox
            // 
            this.groupbox.Controls.Add(this.btDelete);
            this.groupbox.Controls.Add(this.btPay);
            this.groupbox.Controls.Add(this.btSubmit);
            this.groupbox.Controls.Add(this.tbGT);
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.tbSL);
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.Location = new System.Drawing.Point(615, 12);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(308, 256);
            this.groupbox.TabIndex = 1;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Thông tin đơn hàng";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(152, 135);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(141, 45);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Xóa khỏi giỏ hàng";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btPay
            // 
            this.btPay.Location = new System.Drawing.Point(26, 135);
            this.btPay.Name = "btPay";
            this.btPay.Size = new System.Drawing.Size(107, 45);
            this.btPay.TabIndex = 2;
            this.btPay.Text = "Thanh toán";
            this.btPay.UseVisualStyleBackColor = true;
            this.btPay.Click += new System.EventHandler(this.btPay_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(26, 196);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(267, 45);
            this.btSubmit.TabIndex = 3;
            this.btSubmit.Text = "Xác nhận thanh toán";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // tbGT
            // 
            this.tbGT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGT.Enabled = false;
            this.tbGT.Location = new System.Drawing.Point(152, 93);
            this.tbGT.Name = "tbGT";
            this.tbGT.Size = new System.Drawing.Size(141, 22);
            this.tbGT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thành tiền";
            // 
            // tbSL
            // 
            this.tbSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSL.Enabled = false;
            this.tbSL.Location = new System.Drawing.Point(152, 40);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(141, 22);
            this.tbSL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng sách:";
            // 
            // formGH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 276);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.dg);
            this.Name = "formGH";
            this.Text = "Giỏ hàng";
            this.Load += new System.EventHandler(this.formGH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.GroupBox groupbox;
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
    }
}