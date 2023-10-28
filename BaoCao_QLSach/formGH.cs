using BLL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao_QLSach
{
    public partial class formGH : Form
    {
        private TaiKhoanService taikhoanService;
        private SachService sachService = new SachService();
        private GioHangService gioHangService ;
        private ChiTietKsService ctksService;
        private TaiKhoan tk;
        public formGH(TaiKhoanService taikhoanService, TaiKhoan tk, GioHangService gioHangService, ChiTietKsService ctksService)
        {
            InitializeComponent();
            this.taikhoanService = taikhoanService;
            this.tk = tk;
            this.gioHangService = gioHangService;
            this.ctksService = ctksService;
        }
        private void Clear ()
        {
            if (dg.Rows.Count > 0)
            {
                for (int i = 0; i < dg.Rows.Count; i++)
                {
                    if (dg.Rows[i].Cells[0].Value.ToString() == "1")
                    {
                        if (gioHangService.FindGhByTenTK_MaS(tk.TenTK, dg.Rows[i].Cells[1].Value.ToString()) != null)
                        {
                            gioHangService.Remove(gioHangService.FindGhByTenTK_MaS(tk.TenTK, dg.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                }
            }
            gioHangService.Save();
            tbGT.Clear();
            tbSL.Clear();
        }
        private void BindDataGrid ()
        {
            dg.Rows.Clear();
            foreach ( GioHang gh in gioHangService.GetAllGh() )
            {
                if ( gh.TenTK == tk.TenTK )
                {
                    int newRow = dg.Rows.Add();
                    dg.Rows[newRow].Cells[1].Value = sachService.findSachByID(gh.MaSach).MaSach;
                    dg.Rows[newRow].Cells[2].Value = sachService.findSachByID(gh.MaSach).TenSach;
                    dg.Rows[newRow].Cells[3].Value = sachService.findSachByID(gh.MaSach).Tacgia;
                    dg.Rows[newRow].Cells[4].Value = sachService.findSachByID(gh.MaSach).Giaban;
                    dg.Rows[newRow].Cells[5].Value = sachService.findSachByID(gh.MaSach).TheLoai.TenTL;
                    dg.Rows[newRow].Cells[6].Value = gh.SoLuong;
                    dg.Rows[newRow].Cells[7].Value = gh.MaKS;
                }
            }
            dg.Columns[7].Visible = false;
            foreach (DataGridViewRow row in dg.Rows)
            {
                row.Cells["colSelect"].Value = 0;
            }
            dg.Columns[6].DefaultCellStyle.BackColor = Color.Orange;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void formGH_Load(object sender, EventArgs e)
        {
            btSubmit.Enabled = false;
            DataGridViewCheckBoxColumn checkCol = new DataGridViewCheckBoxColumn();
            checkCol.Name = "colSelect";
            checkCol.HeaderText = "Select";
            checkCol.Width = 50;
            checkCol.ReadOnly = false;
            checkCol.TrueValue = 1;
            checkCol.FalseValue = 0;
            dg.Columns.Insert(0, checkCol);
            BindDataGrid();
        }

        private void btPay_Click(object sender, EventArgs e)
        {
            try
            {
                int soluong = 0;
                int giatien = 0;
                int count = 0;
                for (int i = 0; i < dg.Rows.Count; i++)
                {
                    if (dg.Rows[i].Cells[0].Value.ToString() == "1")
                    {
                        count++;
                        soluong += int.Parse(dg.Rows[i].Cells[6].Value.ToString());
                        giatien += (int.Parse(dg.Rows[i].Cells[6].Value.ToString()) * int.Parse(dg.Rows[i].Cells[4].Value.ToString()));
                    }
                }

                if ( count != 0 )
                {
                    btSubmit.Enabled = true;
                } else
                {
                    throw new Exception("Giỏ hàng trống! Không thể thanh toán!");
                }

                tbSL.Text = soluong.ToString();
                tbGT.Text = giatien.ToString();

            } catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btSubmit_Click(object sender, EventArgs e)
        {
            using (var transaction = taikhoanService.BeginTransaction())
            {
                try
                {
                    HoaDon hd = new HoaDon();
                    hd.TenTK = tk.TenTK;
                    hd.Ngaylap = DateTime.Now;
                    for (int i = 0; i < dg.Rows.Count; i++)
                    {
                        if (dg.Rows[i].Cells[0].Value.ToString() == "1")
                        {
                            if (int.Parse(dg.Rows[i].Cells[6].Value.ToString()) != 0 )
                            {
                                if (int.Parse(dg.Rows[i].Cells[6].Value.ToString()) > ctksService.FindKsByMaKS_MaS(dg.Rows[i].Cells[7].Value.ToString(), sachService.findSachByID(dg.Rows[i].Cells[1].Value.ToString()).MaSach).Soluong)
                                {
                                    throw new Exception("Khong du so luong sach co ma: " + dg.Rows[i].Cells[1].Value.ToString());
                                } else
                                {
                                    ChiTiet_HD ct = new ChiTiet_HD();
                                    //ct.MaHD = hd.MaHD;
                                    ct.MaSach = sachService.findSachByID(dg.Rows[i].Cells[1].Value.ToString()).MaSach;
                                    ct.SoLuong = int.Parse(dg.Rows[i].Cells[6].Value.ToString());
                                    hd.ChiTiet_HD.Add(ct);
                                    ctksService.FindKsByMaKS_MaS(dg.Rows[i].Cells[7].Value.ToString(), sachService.findSachByID(dg.Rows[i].Cells[1].Value.ToString()).MaSach).Soluong -= int.Parse(dg.Rows[i].Cells[6].Value.ToString());
                                }
                            }
                        }
                    }
                    hd.Thanhtien = int.Parse(tbGT.Text);
                    tk.HoaDons.Add(hd);
                    ctksService.Save();
                    taikhoanService.Save();
                    Clear();
                    BindDataGrid();
                    MessageBox.Show("Hóa đơn đã được thanh toán!" + "\n" + "Mã hóa đơn: " + hd.MaHD);
                    btSubmit.Enabled = false;
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dg.Rows.Count; i++)
                {
                    if (dg.Rows[i].Cells[0].Value.ToString() == "1")
                    {
                        var findGh = gioHangService.FindGhByTenTK_MaS(tk.TenTK, dg.Rows[i].Cells[1].Value.ToString());
                        if ( findGh != null)
                        {
                            gioHangService.Remove(findGh); 
                        } else
                        {
                            throw new Exception("Khong tim thay sach can xoa!");
                        }
                    }
                }
                gioHangService.Save();
                MessageBox.Show("Da xoa khoi gio hang");
                BindDataGrid();

            } catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int soluong = 0;
                int giatien = 0;
                int count = 0; 
                if (dg.Rows.Count > 0)
                {
                    if ( e.ColumnIndex == 6 )
                    {
                        for (int i = 0; i < dg.Rows.Count; i++)
                        {
                            if (dg.Rows[i].Cells[0].Value.ToString() == "1")
                            {
                                if (dg.Rows[i].Cells[6].Value.ToString() != "" )
                                {
                                    count++;
                                    soluong += int.Parse(dg.Rows[i].Cells[6].Value.ToString());
                                    giatien += (int.Parse(dg.Rows[i].Cells[6].Value.ToString()) * int.Parse(dg.Rows[i].Cells[4].Value.ToString()));
                                } 
                            }
                        }
                        btSubmit.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key is not a digit or a control character
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Cancel the input
                e.Handled = true;
            }
        }
        private void dg_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);

            // Check if the current column is the desired one
            if (dg.CurrentCell.ColumnIndex == 6) // Change 0 to your column index
            {
                // Cast the editing control to a TextBox
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    // Add a new handler
                    tb.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
        }
    }
}
