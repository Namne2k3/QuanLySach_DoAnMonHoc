namespace BaoCao_QLSach
{
    partial class formQuanTiTK
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMK = new System.Windows.Forms.CheckBox();
            this.tbTT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMK);
            this.groupBox1.Controls.Add(this.tbTT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbSL);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbMK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbTK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(269, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 374);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // cbMK
            // 
            this.cbMK.AutoSize = true;
            this.cbMK.Location = new System.Drawing.Point(26, 180);
            this.cbMK.Name = "cbMK";
            this.cbMK.Size = new System.Drawing.Size(130, 20);
            this.cbMK.TabIndex = 8;
            this.cbMK.Text = "Hiển thị mật khẩu";
            this.cbMK.UseVisualStyleBackColor = true;
            this.cbMK.CheckedChanged += new System.EventHandler(this.cbMK_CheckedChanged);
            // 
            // tbTT
            // 
            this.tbTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTT.Location = new System.Drawing.Point(26, 308);
            this.tbTT.Name = "tbTT";
            this.tbTT.ReadOnly = true;
            this.tbTT.Size = new System.Drawing.Size(245, 22);
            this.tbTT.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đã thanh toán";
            // 
            // tbSL
            // 
            this.tbSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSL.Location = new System.Drawing.Point(26, 243);
            this.tbSL.Name = "tbSL";
            this.tbSL.ReadOnly = true;
            this.tbSL.Size = new System.Drawing.Size(245, 22);
            this.tbSL.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng sách đã mua";
            // 
            // tbMK
            // 
            this.tbMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMK.Location = new System.Drawing.Point(26, 151);
            this.tbMK.Name = "tbMK";
            this.tbMK.ReadOnly = true;
            this.tbMK.Size = new System.Drawing.Size(245, 22);
            this.tbMK.TabIndex = 3;
            this.tbMK.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // tbTK
            // 
            this.tbTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTK.Location = new System.Drawing.Point(26, 70);
            this.tbTK.Name = "tbTK";
            this.tbTK.ReadOnly = true;
            this.tbTK.Size = new System.Drawing.Size(245, 22);
            this.tbTK.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên tài khoản";
            // 
            // dtg
            // 
            this.dtg.AllowUserToAddRows = false;
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Location = new System.Drawing.Point(584, 132);
            this.dtg.Name = "dtg";
            this.dtg.ReadOnly = true;
            this.dtg.RowHeadersVisible = false;
            this.dtg.RowHeadersWidth = 51;
            this.dtg.RowTemplate.Height = 24;
            this.dtg.Size = new System.Drawing.Size(621, 365);
            this.dtg.TabIndex = 2;
            this.dtg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CellClick);
            // 
            // formQuanTiTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 594);
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formQuanTiTK";
            this.Text = "formQuanTiTK";
            this.Load += new System.EventHandler(this.formQuanTiTK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbMK;
    }
}