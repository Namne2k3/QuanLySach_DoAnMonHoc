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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNhapLai = new System.Windows.Forms.CheckBox();
            this.cbNewMK = new System.Windows.Forms.CheckBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.tbNhapLai = new System.Windows.Forms.TextBox();
            this.tbNewMk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errNhapLaiMk = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNhapLaiMk)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNhapLai);
            this.groupBox1.Controls.Add(this.cbNewMK);
            this.groupBox1.Controls.Add(this.btSubmit);
            this.groupBox1.Controls.Add(this.tbNhapLai);
            this.groupBox1.Controls.Add(this.tbNewMk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thay đổi mật khẩu";
            // 
            // cbNhapLai
            // 
            this.cbNhapLai.AutoSize = true;
            this.cbNhapLai.Location = new System.Drawing.Point(237, 172);
            this.cbNhapLai.Name = "cbNhapLai";
            this.cbNhapLai.Size = new System.Drawing.Size(171, 26);
            this.cbNhapLai.TabIndex = 6;
            this.cbNhapLai.Text = "Hiển thị mật khẩu";
            this.cbNhapLai.UseVisualStyleBackColor = true;
            this.cbNhapLai.CheckedChanged += new System.EventHandler(this.cbNhapLai_CheckedChanged);
            // 
            // cbNewMK
            // 
            this.cbNewMK.AutoSize = true;
            this.cbNewMK.Location = new System.Drawing.Point(237, 87);
            this.cbNewMK.Name = "cbNewMK";
            this.cbNewMK.Size = new System.Drawing.Size(171, 26);
            this.cbNewMK.TabIndex = 5;
            this.cbNewMK.Text = "Hiển thị mật khẩu";
            this.cbNewMK.UseVisualStyleBackColor = true;
            this.cbNewMK.CheckedChanged += new System.EventHandler(this.cbNewMK_CheckedChanged);
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(361, 219);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(134, 43);
            this.btSubmit.TabIndex = 4;
            this.btSubmit.Text = "Xác nhận";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // tbNhapLai
            // 
            this.tbNhapLai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNhapLai.Location = new System.Drawing.Point(237, 136);
            this.tbNhapLai.Name = "tbNhapLai";
            this.tbNhapLai.Size = new System.Drawing.Size(258, 28);
            this.tbNhapLai.TabIndex = 3;
            // 
            // tbNewMk
            // 
            this.tbNewMk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewMk.Location = new System.Drawing.Point(237, 53);
            this.tbNewMk.Name = "tbNewMk";
            this.tbNewMk.Size = new System.Drawing.Size(258, 28);
            this.tbNewMk.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập lại mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu mới:";
            // 
            // errNhapLaiMk
            // 
            this.errNhapLaiMk.ContainerControl = this;
            // 
            // formChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 306);
            this.Controls.Add(this.groupBox1);
            this.Name = "formChangePass";
            this.Text = "Thay đổi mật khẩu";
            this.Load += new System.EventHandler(this.formChangePass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNhapLaiMk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.TextBox tbNhapLai;
        private System.Windows.Forms.TextBox tbNewMk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errNhapLaiMk;
        private System.Windows.Forms.CheckBox cbNhapLai;
        private System.Windows.Forms.CheckBox cbNewMK;
    }
}