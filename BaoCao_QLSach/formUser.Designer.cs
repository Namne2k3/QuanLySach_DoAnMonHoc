namespace BaoCao_QLSach
{
    partial class formUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUser));
            this.dv = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbKS = new System.Windows.Forms.ComboBox();
            this.btAddCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTL = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btAccount = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btFeedback = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dv
            // 
            this.dv.AllowUserToAddRows = false;
            this.dv.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colTen,
            this.colTG,
            this.colGB,
            this.colTL,
            this.colSL});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dv.Location = new System.Drawing.Point(28, 220);
            this.dv.Name = "dv";
            this.dv.RowHeadersVisible = false;
            this.dv.RowHeadersWidth = 51;
            this.dv.RowTemplate.Height = 24;
            this.dv.Size = new System.Drawing.Size(858, 402);
            this.dv.TabIndex = 2;
            this.dv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_CellClick);
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
            this.colSL.HeaderText = "Số lượng có sẵn";
            this.colSL.MinimumWidth = 6;
            this.colSL.Name = "colSL";
            this.colSL.ReadOnly = true;
            this.colSL.Width = 125;
            // 
            // cbKS
            // 
            this.cbKS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.cbKS.FormattingEnabled = true;
            this.cbKS.Location = new System.Drawing.Point(198, 107);
            this.cbKS.Name = "cbKS";
            this.cbKS.Size = new System.Drawing.Size(154, 30);
            this.cbKS.TabIndex = 3;
            this.cbKS.SelectedIndexChanged += new System.EventHandler(this.cbKS_SelectedIndexChanged);
            // 
            // btAddCart
            // 
            this.btAddCart.AutoSize = true;
            this.btAddCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btAddCart.FlatAppearance.BorderSize = 0;
            this.btAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddCart.ForeColor = System.Drawing.Color.White;
            this.btAddCart.Location = new System.Drawing.Point(693, 155);
            this.btAddCart.Name = "btAddCart";
            this.btAddCart.Size = new System.Drawing.Size(193, 34);
            this.btAddCart.TabIndex = 4;
            this.btAddCart.Text = "Thêm vào giỏ hàng";
            this.btAddCart.UseVisualStyleBackColor = false;
            this.btAddCart.Click += new System.EventHandler(this.btAddCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(24, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sách có sẵn tại";
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.tbSearch.Location = new System.Drawing.Point(199, 161);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(474, 21);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(24, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tìm kiếm theo tên";
            // 
            // cbTL
            // 
            this.cbTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.cbTL.FormattingEnabled = true;
            this.cbTL.Location = new System.Drawing.Point(509, 107);
            this.cbTL.Name = "cbTL";
            this.cbTL.Size = new System.Drawing.Size(154, 30);
            this.cbTL.TabIndex = 8;
            this.cbTL.SelectedIndexChanged += new System.EventHandler(this.cbTL_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(411, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thể loại";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(198, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 1);
            this.panel2.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(911, 53);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCart);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 66);
            this.panel1.TabIndex = 0;
            // 
            // btCart
            // 
            this.btCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btCart.FlatAppearance.BorderSize = 0;
            this.btCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCart.ForeColor = System.Drawing.Color.White;
            this.btCart.Image = ((System.Drawing.Image)(resources.GetObject("btCart.Image")));
            this.btCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCart.Location = new System.Drawing.Point(-3, -16);
            this.btCart.Name = "btCart";
            this.btCart.Padding = new System.Windows.Forms.Padding(12);
            this.btCart.Size = new System.Drawing.Size(234, 82);
            this.btCart.TabIndex = 12;
            this.btCart.Text = "    Giỏ Hàng";
            this.btCart.UseVisualStyleBackColor = false;
            this.btCart.Click += new System.EventHandler(this.btCart_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btAccount);
            this.panel3.Location = new System.Drawing.Point(209, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 66);
            this.panel3.TabIndex = 1;
            // 
            // btAccount
            // 
            this.btAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btAccount.FlatAppearance.BorderSize = 0;
            this.btAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAccount.ForeColor = System.Drawing.Color.White;
            this.btAccount.Image = ((System.Drawing.Image)(resources.GetObject("btAccount.Image")));
            this.btAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAccount.Location = new System.Drawing.Point(-10, -16);
            this.btAccount.Name = "btAccount";
            this.btAccount.Padding = new System.Windows.Forms.Padding(12);
            this.btAccount.Size = new System.Drawing.Size(234, 82);
            this.btAccount.TabIndex = 13;
            this.btAccount.Text = "    Tài Khoản";
            this.btAccount.UseVisualStyleBackColor = false;
            this.btAccount.Click += new System.EventHandler(this.btAccount_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btFeedback);
            this.panel4.Location = new System.Drawing.Point(415, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 66);
            this.panel4.TabIndex = 2;
            // 
            // btFeedback
            // 
            this.btFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btFeedback.FlatAppearance.BorderSize = 0;
            this.btFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFeedback.ForeColor = System.Drawing.Color.White;
            this.btFeedback.Image = ((System.Drawing.Image)(resources.GetObject("btFeedback.Image")));
            this.btFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFeedback.Location = new System.Drawing.Point(0, -16);
            this.btFeedback.Name = "btFeedback";
            this.btFeedback.Padding = new System.Windows.Forms.Padding(12);
            this.btFeedback.Size = new System.Drawing.Size(234, 82);
            this.btFeedback.TabIndex = 14;
            this.btFeedback.Text = "    FeedBack";
            this.btFeedback.UseVisualStyleBackColor = false;
            this.btFeedback.Click += new System.EventHandler(this.btFeedback_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btLogout);
            this.panel5.Location = new System.Drawing.Point(621, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(272, 66);
            this.panel5.TabIndex = 3;
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btLogout.FlatAppearance.BorderSize = 0;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.Color.White;
            this.btLogout.Image = ((System.Drawing.Image)(resources.GetObject("btLogout.Image")));
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.Location = new System.Drawing.Point(13, -16);
            this.btLogout.Name = "btLogout";
            this.btLogout.Padding = new System.Windows.Forms.Padding(12);
            this.btLogout.Size = new System.Drawing.Size(271, 82);
            this.btLogout.TabIndex = 15;
            this.btLogout.Text = "    Đăng xuất";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // formUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(911, 681);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAddCart);
            this.Controls.Add(this.cbKS);
            this.Controls.Add(this.dv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mua sách";
            this.Load += new System.EventHandler(this.formUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dv;
        private System.Windows.Forms.ComboBox cbKS;
        private System.Windows.Forms.Button btAddCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btCart;
        private System.Windows.Forms.Button btAccount;
        private System.Windows.Forms.Button btFeedback;
        private System.Windows.Forms.Button btLogout;
    }
}