using BLL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao_QLSach
{
    public partial class formRegister : Form
    {

        private TaiKhoanService taiKhoanService;
        public formRegister(TaiKhoanService taiKhoanService)
        {
            InitializeComponent();
            this.taiKhoanService = taiKhoanService;
        }
        public bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            Regex re = new Regex(strRegex);
            if (inputEmail.ToLower().Contains("@gmail.com") && re.IsMatch(inputEmail))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ResetInput()
        {
            tbEmail.Text = string.Empty;
            tbMK.Text = string.Empty;
            tbTK.Text = string.Empty;
        }
        private void btRegister_Click(object sender, EventArgs e)
        {
            using ( var transaction = taiKhoanService.BeginTransaction() )
            {
                try
                {
                    if ( tbTK.Text.ToLower().Contains("admin".ToLower()) )
                    {
                        throw new Exception("Tên tài khoản chứa 'admin' không được phép tạo!");
                    }

                    if (tbEmail.Text == string.Empty || tbMK.Text == string.Empty || tbTK.Text == string.Empty )
                    {
                        throw new Exception("Vui long nhap day du thong tin!");
                    } 
                    if (!isValidEmail(tbEmail.Text))
                    {
                        throw new Exception("Email khong hop le!");
                    }
                    if (taiKhoanService.FindTkByEmail(tbEmail.Text) != null)
                    {
                        throw new Exception("Email da duoc dang ky o tai khoan khac!");
                    }

                    var findTK = taiKhoanService.FindTkByTenTk(tbTK.Text);
                    if ( findTK != null )
                    {
                        throw new Exception("Ten tai khoan da ton tai! Vui long nhap ten tk khac");
                    } else
                    {
                        TaiKhoan tk = new TaiKhoan();
                        tk.TenTK = tbTK.Text;
                        tk.Mk = tbMK.Text;
                        tk.Email = tbEmail.Text;

                        taiKhoanService.InsertTK( tk );
                        taiKhoanService.Save();
                    }
                    transaction.Commit();
                    MessageBox.Show("Dang ki thanh cong!");
                    ResetInput();

                } catch ( Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void formRegister_Load(object sender, EventArgs e)
        {
            tbMK.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbMK.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
