namespace BaoCao_QLSach
{
    partial class formLogin
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
            this.cbPass = new System.Windows.Forms.CheckBox();
            this.tbMk = new System.Windows.Forms.TextBox();
            this.tbTk = new System.Windows.Forms.TextBox();
            this.linkChuaTK = new System.Windows.Forms.LinkLabel();
            this.linkQuenMK = new System.Windows.Forms.LinkLabel();
            this.btLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPass);
            this.groupBox1.Controls.Add(this.tbMk);
            this.groupBox1.Controls.Add(this.tbTk);
            this.groupBox1.Controls.Add(this.linkChuaTK);
            this.groupBox1.Controls.Add(this.linkQuenMK);
            this.groupBox1.Controls.Add(this.btLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(450, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            // 
            // cbPass
            // 
            this.cbPass.AutoSize = true;
            this.cbPass.Location = new System.Drawing.Point(145, 115);
            this.cbPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPass.Name = "cbPass";
            this.cbPass.Size = new System.Drawing.Size(144, 22);
            this.cbPass.TabIndex = 8;
            this.cbPass.Text = "Hiển thị mật khẩu";
            this.cbPass.UseVisualStyleBackColor = true;
            this.cbPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbMk
            // 
            this.tbMk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMk.Location = new System.Drawing.Point(145, 79);
            this.tbMk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMk.Name = "tbMk";
            this.tbMk.Size = new System.Drawing.Size(291, 24);
            this.tbMk.TabIndex = 7;
            // 
            // tbTk
            // 
            this.tbTk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTk.Location = new System.Drawing.Point(145, 37);
            this.tbTk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTk.Name = "tbTk";
            this.tbTk.Size = new System.Drawing.Size(291, 24);
            this.tbTk.TabIndex = 6;
            // 
            // linkChuaTK
            // 
            this.linkChuaTK.AutoSize = true;
            this.linkChuaTK.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkChuaTK.Location = new System.Drawing.Point(287, 218);
            this.linkChuaTK.Name = "linkChuaTK";
            this.linkChuaTK.Size = new System.Drawing.Size(136, 18);
            this.linkChuaTK.TabIndex = 5;
            this.linkChuaTK.TabStop = true;
            this.linkChuaTK.Text = "Chưa có tài khoản?";
            this.linkChuaTK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChuaTK_LinkClicked);
            // 
            // linkQuenMK
            // 
            this.linkQuenMK.AutoSize = true;
            this.linkQuenMK.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkQuenMK.Location = new System.Drawing.Point(23, 218);
            this.linkQuenMK.Name = "linkQuenMK";
            this.linkQuenMK.Size = new System.Drawing.Size(117, 18);
            this.linkQuenMK.TabIndex = 4;
            this.linkQuenMK.TabStop = true;
            this.linkQuenMK.Text = "Quên mật khẩu?";
            this.linkQuenMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQuenMK_LinkClicked);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(27, 155);
            this.btLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(409, 43);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Đăng nhập";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 282);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "formLogin";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkChuaTK;
        private System.Windows.Forms.LinkLabel linkQuenMK;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMk;
        private System.Windows.Forms.TextBox tbTk;
        private System.Windows.Forms.CheckBox cbPass;
    }
}

