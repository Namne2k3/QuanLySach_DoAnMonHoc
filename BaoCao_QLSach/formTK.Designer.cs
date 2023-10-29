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
            this.btSubmit = new System.Windows.Forms.Button();
            this.btEmail = new System.Windows.Forms.Button();
            this.btPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.DataGridView();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSubmit
            // 
            this.btSubmit.AutoSize = true;
            this.btSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btSubmit.FlatAppearance.BorderSize = 0;
            this.btSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubmit.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmit.ForeColor = System.Drawing.Color.White;
            this.btSubmit.Location = new System.Drawing.Point(574, 304);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(407, 41);
            this.btSubmit.TabIndex = 10;
            this.btSubmit.Text = "Xác nhận";
            this.btSubmit.UseVisualStyleBackColor = false;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btEmail
            // 
            this.btEmail.AutoSize = true;
            this.btEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btEmail.FlatAppearance.BorderSize = 0;
            this.btEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmail.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmail.ForeColor = System.Drawing.Color.White;
            this.btEmail.Location = new System.Drawing.Point(790, 236);
            this.btEmail.Name = "btEmail";
            this.btEmail.Size = new System.Drawing.Size(191, 40);
            this.btEmail.TabIndex = 9;
            this.btEmail.Text = "Thay đổi email";
            this.btEmail.UseVisualStyleBackColor = false;
            this.btEmail.Click += new System.EventHandler(this.btEmail_Click);
            // 
            // btPass
            // 
            this.btPass.AutoSize = true;
            this.btPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btPass.FlatAppearance.BorderSize = 0;
            this.btPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPass.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPass.ForeColor = System.Drawing.Color.White;
            this.btPass.Location = new System.Drawing.Point(574, 236);
            this.btPass.Name = "btPass";
            this.btPass.Size = new System.Drawing.Size(198, 40);
            this.btPass.TabIndex = 8;
            this.btPass.Text = "Thay đổi mật khẩu";
            this.btPass.UseVisualStyleBackColor = false;
            this.btPass.Click += new System.EventHandler(this.btPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Các hóa đơn đã thanh toán";
            // 
            // dt
            // 
            this.dt.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.Location = new System.Drawing.Point(3, 59);
            this.dt.Name = "dt";
            this.dt.RowHeadersWidth = 51;
            this.dt.RowTemplate.Height = 24;
            this.dt.Size = new System.Drawing.Size(528, 442);
            this.dt.TabIndex = 6;
            this.dt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_CellDoubleClick);
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Enabled = false;
            this.tbEmail.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.tbEmail.Location = new System.Drawing.Point(689, 150);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(292, 22);
            this.tbEmail.TabIndex = 5;
            // 
            // tbMK
            // 
            this.tbMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMK.Enabled = false;
            this.tbMK.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.tbMK.Location = new System.Drawing.Point(689, 84);
            this.tbMK.Name = "tbMK";
            this.tbMK.Size = new System.Drawing.Size(292, 22);
            this.tbMK.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(570, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(570, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dt);
            this.panel1.Location = new System.Drawing.Point(-2, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 489);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label5.Location = new System.Drawing.Point(669, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thông tin tài khoản";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(690, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 1);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(690, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 1);
            this.panel3.TabIndex = 13;
            // 
            // formTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1043, 384);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.tbMK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btEmail);
            this.Controls.Add(this.btPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formTK";
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.formTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.Button btEmail;
        private System.Windows.Forms.Button btPass;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}