namespace BaoCao_QLSach
{
    partial class formTK
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
            this.label4 = new System.Windows.Forms.Label();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btEmail = new System.Windows.Forms.Button();
            this.btPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.DataGridView();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btSubmit);
            this.groupBox1.Controls.Add(this.btEmail);
            this.groupBox1.Controls.Add(this.btPass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dt);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbMK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(494, 467);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(265, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "( double click để xem chi tiết )";
            // 
            // btSubmit
            // 
            this.btSubmit.AutoSize = true;
            this.btSubmit.Location = new System.Drawing.Point(292, 123);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(114, 32);
            this.btSubmit.TabIndex = 10;
            this.btSubmit.Text = "Xác nhận";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btEmail
            // 
            this.btEmail.AutoSize = true;
            this.btEmail.Location = new System.Drawing.Point(27, 161);
            this.btEmail.Name = "btEmail";
            this.btEmail.Size = new System.Drawing.Size(140, 32);
            this.btEmail.TabIndex = 9;
            this.btEmail.Text = "Thay đổi email";
            this.btEmail.UseVisualStyleBackColor = true;
            this.btEmail.Click += new System.EventHandler(this.btEmail_Click);
            // 
            // btPass
            // 
            this.btPass.AutoSize = true;
            this.btPass.Location = new System.Drawing.Point(27, 123);
            this.btPass.Name = "btPass";
            this.btPass.Size = new System.Drawing.Size(140, 32);
            this.btPass.TabIndex = 8;
            this.btPass.Text = "Thay đổi mật khẩu";
            this.btPass.UseVisualStyleBackColor = true;
            this.btPass.Click += new System.EventHandler(this.btPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Các hóa đơn đã thanh toán";
            // 
            // dt
            // 
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.Location = new System.Drawing.Point(27, 244);
            this.dt.Name = "dt";
            this.dt.RowHeadersWidth = 51;
            this.dt.RowTemplate.Height = 24;
            this.dt.Size = new System.Drawing.Size(440, 206);
            this.dt.TabIndex = 6;
            this.dt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_CellDoubleClick);
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(114, 75);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(292, 24);
            this.tbEmail.TabIndex = 5;
            // 
            // tbMK
            // 
            this.tbMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMK.Enabled = false;
            this.tbMK.Location = new System.Drawing.Point(114, 37);
            this.tbMK.Name = "tbMK";
            this.tbMK.Size = new System.Drawing.Size(292, 24);
            this.tbMK.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // formTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 494);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formTK";
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.formTK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.Button btEmail;
        private System.Windows.Forms.Button btPass;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label label4;
    }
}