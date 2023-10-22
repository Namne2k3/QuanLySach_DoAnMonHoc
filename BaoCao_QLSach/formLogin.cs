using BLL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao_QLSach
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        TaiKhoanService taiKhoanService = new TaiKhoanService();
        private void Form1_Load(object sender, EventArgs e)
        {
            tbMk.UseSystemPasswordChar = true;
        }
        private void linkQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formForgotPass form = new formForgotPass(taiKhoanService);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        private void linkChuaTK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formRegister form = new formRegister(taiKhoanService);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        private void Login()
        {
            try
            {
                if ( tbTk.Text == string.Empty || tbMk.Text == string.Empty )
                {
                    throw new Exception("Vui long nhap day du thong tin!");
                }

                var findTk = taiKhoanService.FindTkByTenTk(tbTk.Text);
                if (findTk != null)
                {
                    if ( findTk.TenTK == "admin" )
                    {
                        formAdmin form = new formAdmin();
                        this.Hide();
                        form.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        if (findTk.Mk == tbMk.Text)
                        {
                            formUser form = new formUser(taiKhoanService, findTk);
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            throw new Exception("Sai mat khau!");
                        }
                    }
                }
                else
                {
                    throw new Exception("Tai khoan khong ton tai!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbMk.UseSystemPasswordChar = !cbPass.Checked;
        }
    }
}
