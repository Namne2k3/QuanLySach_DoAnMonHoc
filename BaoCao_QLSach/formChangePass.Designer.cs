namespace BaoCao_QLSach
{
    partial class formChangePass
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChangePass));
            this.cbNhapLai = new System.Windows.Forms.CheckBox();
            this.cbNewMK = new System.Windows.Forms.CheckBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.tbNhapLai = new System.Windows.Forms.TextBox();
            this.tbNewMk = new System.Windows.Forms.TextBox();
            this.errNhapLaiMk = new System.Windows.Forms.ErrorProvider(this.components);
            this.btExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errNhapLaiMk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNhapLai
            // 
            this.cbNhapLai.AutoSize = true;
            this.cbNhapLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.cbNhapLai.Location = new System.Drawing.Point(21, 221);
            this.cbNhapLai.Name = "cbNhapLai";
            this.cbNhapLai.Size = new System.Drawing.Size(130, 20);
            this.cbNhapLai.TabIndex = 6;
            this.cbNhapLai.Text = "Hiển thị mật khẩu";
            this.cbNhapLai.UseVisualStyleBackColor = true;
            this.cbNhapLai.CheckedChanged += new System.EventHandler(this.cbNhapLai_CheckedChanged);
            // 
            // cbNewMK
            // 
            this.cbNewMK.AutoSize = true;
            this.cbNewMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.cbNewMK.Location = new System.Drawing.Point(21, 146);
            this.cbNewMK.Name = "cbNewMK";
            this.cbNewMK.Size = new System.Drawing.Size(130, 20);
            this.cbNewMK.TabIndex = 5;
            this.cbNewMK.Text = "Hiển thị mật khẩu";
            this.cbNewMK.UseVisualStyleBackColor = true;
            this.cbNewMK.CheckedChanged += new System.EventHandler(this.cbNewMK_CheckedChanged);
            // 
            // btSubmit
            // 
            this.btSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btSubmit.FlatAppearance.BorderSize = 0;
            this.btSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubmit.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmit.ForeColor = System.Drawing.Color.White;
            this.btSubmit.Location = new System.Drawing.Point(22, 275);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(398, 54);
            this.btSubmit.TabIndex = 4;
            this.btSubmit.Text = "Xác nhận";
            this.btSubmit.UseVisualStyleBackColor = false;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // tbNhapLai
            // 
            this.tbNhapLai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNhapLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.tbNhapLai.Location = new System.Drawing.Point(52, 188);
            this.tbNhapLai.Name = "tbNhapLai";
            this.tbNhapLai.Size = new System.Drawing.Size(368, 28);
            this.tbNhapLai.TabIndex = 3;
            // 
            // tbNewMk
            // 
            this.tbNewMk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewMk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.tbNewMk.Location = new System.Drawing.Point(52, 109);
            this.tbNewMk.Name = "tbNewMk";
            this.tbNewMk.Size = new System.Drawing.Size(370, 28);
            this.tbNewMk.TabIndex = 2;
            // 
            // errNhapLaiMk
            // 
            this.errNhapLaiMk.ContainerControl = this;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Location = new System.Drawing.Point(286, 358);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(134, 43);
            this.btExit.TabIndex = 10;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(23, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 1);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(22, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(87, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thay đổi mật khẩu";
            // 
            // formChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(456, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.cbNhapLai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbNewMK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbNhapLai);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tbNewMk);
            this.Controls.Add(this.btExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formChangePass";
            this.Text = "Thay đổi mật khẩu";
            this.Load += new System.EventHandler(this.formChangePass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errNhapLaiMk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.TextBox tbNhapLai;
        private System.Windows.Forms.TextBox tbNewMk;
        private System.Windows.Forms.ErrorProvider errNhapLaiMk;
        private System.Windows.Forms.CheckBox cbNhapLai;
        private System.Windows.Forms.CheckBox cbNewMK;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}