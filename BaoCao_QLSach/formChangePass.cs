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
    public partial class formChangePass : Form
    {
        private TaiKhoanService taiKhoanService;
        private TaiKhoan tk;
        public formChangePass(TaiKhoanService taiKhoanService, TaiKhoan tk)
        {
            InitializeComponent();
            this.taiKhoanService = taiKhoanService;
            this.tk = tk;
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if ( tbNewMk.Text == string.Empty )
                {
                    throw new Exception("Vui long nhap mat khau moi!");
                }

                if ( tbNhapLai.Text == string.Empty )
                {
                    throw new Exception("Vui long nhap lai mat khau moi!");
                }
                
                if ( tbNhapLai.Text != tbNewMk.Text )
                {
                    throw new Exception("Nhap lai mat khau moi khong dung!");
                } else
                {
                    tk.Mk = tbNhapLai.Text;
                    taiKhoanService.Save();
                    MessageBox.Show("Cap nhat mat khau thanh cong!");
                    this.Close();
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void formChangePass_Load(object sender, EventArgs e)
        {
            tbNewMk.UseSystemPasswordChar = true;
            tbNhapLai.UseSystemPasswordChar = true;
        }

        private void cbNewMK_CheckedChanged(object sender, EventArgs e)
        {
            tbNewMk.UseSystemPasswordChar = !cbNewMK.Checked;
        }

        private void cbNhapLai_CheckedChanged(object sender, EventArgs e)
        {
            tbNhapLai.UseSystemPasswordChar= !cbNhapLai.Checked;
        }
    }
}
