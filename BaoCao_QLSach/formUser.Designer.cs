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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gioHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.đăngFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(767, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gioHangToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.đăngFeedbackToolStripMenuItem,
            this.toolStripSeparator1,
            this.đăngXuấtToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // gioHangToolStripMenuItem
            // 
            this.gioHangToolStripMenuItem.Name = "gioHangToolStripMenuItem";
            this.gioHangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gioHangToolStripMenuItem.Text = "Giỏ hàng";
            this.gioHangToolStripMenuItem.Click += new System.EventHandler(this.gioHangToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // dv
            // 
            this.dv.AllowUserToAddRows = false;
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colTen,
            this.colTG,
            this.colGB,
            this.colTL,
            this.colSL});
            this.dv.Location = new System.Drawing.Point(22, 113);
            this.dv.Name = "dv";
            this.dv.RowHeadersVisible = false;
            this.dv.RowHeadersWidth = 51;
            this.dv.RowTemplate.Height = 24;
            this.dv.Size = new System.Drawing.Size(723, 320);
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
            this.cbKS.FormattingEnabled = true;
            this.cbKS.Location = new System.Drawing.Point(151, 42);
            this.cbKS.Name = "cbKS";
            this.cbKS.Size = new System.Drawing.Size(154, 24);
            this.cbKS.TabIndex = 3;
            this.cbKS.SelectedIndexChanged += new System.EventHandler(this.cbKS_SelectedIndexChanged);
            // 
            // btAddCart
            // 
            this.btAddCart.AutoSize = true;
            this.btAddCart.Location = new System.Drawing.Point(612, 80);
            this.btAddCart.Name = "btAddCart";
            this.btAddCart.Size = new System.Drawing.Size(133, 26);
            this.btAddCart.TabIndex = 4;
            this.btAddCart.Text = "Thêm vào giỏ hàng";
            this.btAddCart.UseVisualStyleBackColor = true;
            this.btAddCart.Click += new System.EventHandler(this.btAddCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sách có sẵn tại";
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Location = new System.Drawing.Point(151, 80);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(394, 22);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tìm kiếm theo tên";
            // 
            // cbTL
            // 
            this.cbTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTL.FormattingEnabled = true;
            this.cbTL.Location = new System.Drawing.Point(391, 42);
            this.cbTL.Name = "cbTL";
            this.cbTL.Size = new System.Drawing.Size(154, 24);
            this.cbTL.TabIndex = 8;
            this.cbTL.SelectedIndexChanged += new System.EventHandler(this.cbTL_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thể loại";
            // 
            // đăngFeedbackToolStripMenuItem
            // 
            this.đăngFeedbackToolStripMenuItem.Name = "đăngFeedbackToolStripMenuItem";
            this.đăngFeedbackToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngFeedbackToolStripMenuItem.Text = "Đăng Feedback";
            this.đăngFeedbackToolStripMenuItem.Click += new System.EventHandler(this.đăngFeedbackToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // formUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAddCart);
            this.Controls.Add(this.cbKS);
            this.Controls.Add(this.dv);
            this.Controls.Add(this.menuStrip2);
            this.Name = "formUser";
            this.Text = "Mua sách";
            this.Load += new System.EventHandler(this.formUser_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gioHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.DataGridView dv;
        private System.Windows.Forms.ComboBox cbKS;
        private System.Windows.Forms.Button btAddCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.ToolStripMenuItem đăngFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}