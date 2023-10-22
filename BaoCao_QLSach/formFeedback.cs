using BaoCao_QLSach.Properties;
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
    public partial class formFeedback : Form
    {
        private TaiKhoan tk;
        private ChiTiet_HoaDonService cthdService = new ChiTiet_HoaDonService();
        private SachService sachService = new SachService();
        private TaiKhoanService taiKhoanService = new TaiKhoanService();
        private feedbackService feedbackService = new feedbackService();
        int rating = 0;
        public formFeedback(TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
        }
        private void BindDataGrid()
        {
            List<Sach> tempList = new List<Sach>();
            foreach ( var hd in tk.HoaDons )
            {
                foreach ( var cthd in cthdService.FindAllCTHD() )
                {
                    if ( cthd.MaHD == hd.MaHD )
                    {
                        tempList.Add(sachService.findSachByID(cthd.MaSach));
                    }
                }
            }
            dtg.DataSource = tempList.Distinct().ToList();
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg.Columns[4].Visible = false;
            dtg.Columns[5].Visible = false;
            dtg.Columns[6].Visible = false;
            dtg.Columns[7].Visible = false;
            dtg.Columns[8].Visible = false;
            dtg.Columns[9].Visible = false;
            dtg.Columns[10].Visible = false;
            dtg.Columns[11].Visible = false;
            dtg.Columns[12].Visible = false;
        }
        private void formFeedback_Load(object sender, EventArgs e)
        {
            BindDataGrid();
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMS.Text = dtg.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btFB_Click(object sender, EventArgs e)
        {
            try
            {   
                if ( tbMS.Text == string.Empty )
                {
                    throw new Exception("Chưa chọn sách!");
                }
                else
                {

                    if ( rating != 0 )
                    {
                        if (feedbackService.FindFb(tk.TenTK, tbMS.Text) != null )
                        {
                            feedbackService.FindFb(tk.TenTK, tbMS.Text).DanhGia = rating;
                            feedbackService.FindFb(tk.TenTK, tbMS.Text).Phanhoi = rtbFB.Text.Trim();
                            DialogResult result = MessageBox.Show("Xác nhận một lần nữa cập nhật feedback", "Cập nhật feedback", MessageBoxButtons.OKCancel);
                            if (result == DialogResult.OK)
                            {
                                feedbackService.Save();
                                MessageBox.Show("Cám ơn bạn đã chỉnh sửa phản hồi!");
                            }
                        } else
                        {
                            Feedback fb = new Feedback();
                            fb.TenTK = tk.TenTK;
                            fb.MaSach = tbMS.Text;
                            fb.DanhGia = rating;
                            fb.Phanhoi = rtbFB.Text.Trim();

                            DialogResult result = MessageBox.Show("Xác nhận một lần nữa đăng feedback", "Đăng feedback", MessageBoxButtons.OKCancel);
                            if (result == DialogResult.OK)
                            {
                                feedbackService.Add(fb);
                                feedbackService.Save();
                                MessageBox.Show("Cám ơn bạn đã phản hồi!");
                            }
                        }
                    } 
                    else
                    {
                        throw new Exception("Bắt buộc phải có đánh giá!");
                    }
                }
            } catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ptb1_Click(object sender, EventArgs e)
        {
            rating = 1;

            ptb1.Image = Resources.star_filled;
            ptb2.Image = Resources.star;
            ptb3.Image = Resources.star;
            ptb4.Image = Resources.star;
            ptb5.Image = Resources.star;
        }

        private void ptb2_Click(object sender, EventArgs e)
        {
            rating = 2;

            ptb1.Image = Resources.star_filled;
            ptb2.Image = Resources.star_filled;
            ptb3.Image = Resources.star;
            ptb4.Image = Resources.star;
            ptb5.Image = Resources.star;
        }

        private void ptb3_Click(object sender, EventArgs e)
        {
            rating = 3;

            ptb1.Image = Resources.star_filled;
            ptb2.Image = Resources.star_filled;
            ptb3.Image = Resources.star_filled;
            ptb4.Image = Resources.star;
            ptb5.Image = Resources.star;
        }

        private void ptb4_Click(object sender, EventArgs e)
        {
            rating = 4;

            ptb1.Image = Resources.star_filled;
            ptb2.Image = Resources.star_filled;
            ptb3.Image = Resources.star_filled;
            ptb4.Image = Resources.star_filled;
            ptb5.Image = Resources.star;
        }

        private void ptb5_Click(object sender, EventArgs e)
        {
            rating = 5;

            ptb1.Image = Resources.star_filled;
            ptb2.Image = Resources.star_filled;
            ptb3.Image = Resources.star_filled;
            ptb4.Image = Resources.star_filled;
            ptb5.Image = Resources.star_filled;
        }
    }
}
