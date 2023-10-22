using BLL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao_QLSach
{
    public partial class formTK : Form
    {
        private TaiKhoan tk;
        private TaiKhoanService taiKhoanService;
        private HoaDonService hoaDonService = new HoaDonService();
        public formTK( TaiKhoanService taiKhoanService, TaiKhoan tk )
        {
            InitializeComponent();
            this.taiKhoanService = taiKhoanService;
            this.tk = tk;
        }
        private void Reset()
        {
            tbEmail.Enabled = false;
            btSubmit.Visible = false;
        }
        private void BindDataGrid()
        {
            dt.DataSource = tk.HoaDons.ToList();
            dt.Columns[2].Visible = false;
            dt.Columns[4].Visible = false;
            dt.Columns[5].Visible = false;
            dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt.ReadOnly = true;
        }
        private void formTK_Load(object sender, EventArgs e)
        {
            tbMK.UseSystemPasswordChar = true;
            tbMK.Text = tk.Mk;
            tbEmail.Text = tk.Email;

            btSubmit.Visible = false;
            BindDataGrid();
        }

        private void btEmail_Click(object sender, EventArgs e)
        {
            tbEmail.Enabled = true;
            btSubmit.Visible = true;
        }

        private void btPass_Click(object sender, EventArgs e)
        {
            formChangePass form = new formChangePass(taiKhoanService, tk);
            form.ShowDialog();
        }
        public bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        private void btSubmit_Click(object sender, EventArgs e)
        {
            using ( var transaction = taiKhoanService.BeginTransaction() )
            {
                try
                {
                    if (!isValidEmail(tbEmail.Text))
                    {
                        throw new Exception("Email khong hop le!");
                    }
                    
                    var findTk = taiKhoanService.FindTkByEmail(tbEmail.Text);

                    if (findTk != null)
                    {
                        throw new Exception("Email đã được đăng ký! Nhập lại email");
                    } else
                    {
                        tk.Email = tbEmail.Text;
                    }


                    taiKhoanService.Save();
                    MessageBox.Show("Cập nhật email thành công!");
                    Reset();
                    transaction.Commit();
                } catch ( Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            formCT_HD form = new formCT_HD(hoaDonService.FindHdByMaHd(int.Parse(dt.Rows[e.RowIndex].Cells[0].Value.ToString())));
            form.Show();
        }
    }
}
