using BLL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao_QLSach
{
    public partial class formUser : Form
    {
        private KhoSachService khoSachService = new KhoSachService();
        private TaiKhoanService taiKhoanService;
        private SachService sachService = new SachService();
        private TheLoaiService theLoaiService = new TheLoaiService();
        private ChiTietKsService ctksService = new ChiTietKsService();
        private GioHangService ghService = new GioHangService();
        private TaiKhoan tk;
        public formUser(TaiKhoanService taiKhoanService, TaiKhoan tk)
        {
            InitializeComponent();
            this.taiKhoanService = taiKhoanService;
            this.tk = tk;
        }
        private void BindDataGrid(KhoSach ks, string search = null, string tl = null )
        {
            if ( ks != null)
            {
                if ( tl != "TL0" )
                {
                    if ( search != null )
                    {
                        dv.Rows.Clear();
                        foreach (var item in ks.ChiTiet_KS)
                        {
                            if (sachService.findSachByID(item.MaSach).MaTL == tl && sachService.findSachByID(item.MaSach).TenSach.ToLower().Contains(search.ToLower()) )
                            {
                                int newRow = dv.Rows.Add();
                                dv.Rows[newRow].Cells[1].Value = sachService.findSachByID(item.MaSach).MaSach;
                                dv.Rows[newRow].Cells[2].Value = sachService.findSachByID(item.MaSach).TenSach;
                                dv.Rows[newRow].Cells[3].Value = sachService.findSachByID(item.MaSach).Tacgia;
                                dv.Rows[newRow].Cells[4].Value = sachService.findSachByID(item.MaSach).Giaban;
                                dv.Rows[newRow].Cells[5].Value = sachService.findSachByID(item.MaSach).TheLoai.TenTL;
                                dv.Rows[newRow].Cells[6].Value = ctksService.FindSlBy(ks.MaKS,item.MaSach);
                            }
                        }
                        foreach (DataGridViewRow row in dv.Rows)
                            row.Cells["colSelect"].Value = 0;

                        dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    } 
                    else
                    {
                        dv.Rows.Clear();
                        foreach (var item in ks.ChiTiet_KS)
                        {
                            if (sachService.findSachByID(item.MaSach).MaTL == tl )
                            {
                                int newRow = dv.Rows.Add();
                                dv.Rows[newRow].Cells[1].Value = sachService.findSachByID(item.MaSach).MaSach;
                                dv.Rows[newRow].Cells[2].Value = sachService.findSachByID(item.MaSach).TenSach;
                                dv.Rows[newRow].Cells[3].Value = sachService.findSachByID(item.MaSach).Tacgia;
                                dv.Rows[newRow].Cells[4].Value = sachService.findSachByID(item.MaSach).Giaban;
                                dv.Rows[newRow].Cells[5].Value = sachService.findSachByID(item.MaSach).TheLoai.TenTL;
                                dv.Rows[newRow].Cells[6].Value = ctksService.FindSlBy(ks.MaKS, item.MaSach);
                            }
                        }
                        foreach (DataGridViewRow row in dv.Rows)
                            row.Cells["colSelect"].Value = 0;

                        dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                } 
                else
                {
                    if ( search != null )
                    {
                        dv.Rows.Clear();
                        foreach (var item in ks.ChiTiet_KS)
                        {
                            if (sachService.findSachByID(item.MaSach).TenSach.ToLower().Contains(search.ToLower()))
                            {
                                int newRow = dv.Rows.Add();
                                dv.Rows[newRow].Cells[1].Value = sachService.findSachByID(item.MaSach).MaSach;
                                dv.Rows[newRow].Cells[2].Value = sachService.findSachByID(item.MaSach).TenSach;
                                dv.Rows[newRow].Cells[3].Value = sachService.findSachByID(item.MaSach).Tacgia;
                                dv.Rows[newRow].Cells[4].Value = sachService.findSachByID(item.MaSach).Giaban;
                                dv.Rows[newRow].Cells[5].Value = sachService.findSachByID(item.MaSach).TheLoai.TenTL;
                                dv.Rows[newRow].Cells[6].Value = ctksService.FindSlBy(ks.MaKS, item.MaSach);
                            }
                        }
                        foreach (DataGridViewRow row in dv.Rows)
                            row.Cells["colSelect"].Value = 0;

                        dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        dv.Rows.Clear();
                        foreach (var item in ks.ChiTiet_KS)
                        {
                            int newRow = dv.Rows.Add();
                            dv.Rows[newRow].Cells[1].Value = sachService.findSachByID(item.MaSach).MaSach;
                            dv.Rows[newRow].Cells[2].Value = sachService.findSachByID(item.MaSach).TenSach;
                            dv.Rows[newRow].Cells[3].Value = sachService.findSachByID(item.MaSach).Tacgia;
                            dv.Rows[newRow].Cells[4].Value = sachService.findSachByID(item.MaSach).Giaban;
                            dv.Rows[newRow].Cells[5].Value = sachService.findSachByID(item.MaSach).TheLoai.TenTL;
                            dv.Rows[newRow].Cells[6].Value = ctksService.FindSlBy(ks.MaKS, item.MaSach);
                        }
                        foreach (DataGridViewRow row in dv.Rows)
                            row.Cells["colSelect"].Value = 0;
                    
                        dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            } 
        }
        private void bindDataComboBox()
        {
            cbKS.DataSource = khoSachService.GetAllKS();
            cbKS.DisplayMember = "TenKS";
            cbKS.ValueMember = "MaKS";
        }
        private void BindComboBoxTl()
        {
            cbTL.DataSource = theLoaiService.GetAllTl();
            cbTL.DisplayMember = "TenTL";
            cbTL.ValueMember = "MaTL";
        }
        private void formUser_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn checkCol = new DataGridViewCheckBoxColumn();
            checkCol.Name = "colSelect";
            checkCol.HeaderText = "Select";
            checkCol.Width = 50;
            checkCol.ReadOnly = false;
            checkCol.TrueValue = 1;
            checkCol.FalseValue = 0;
            dv.Columns.Insert(0, checkCol);

            bindDataComboBox();
            BindComboBoxTl();
            BindDataGrid(khoSachService.FindKsById(cbKS.SelectedValue.ToString()),null, cbTL.SelectedValue.ToString());
        }

        private void dv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAddCart_Click(object sender, EventArgs e)
        {
            try
            {
                for ( int i = 0; i < dv.Rows.Count; i++ )
                {
                    if (dv.Rows[i].Cells[0].Value.ToString() == "1" )
                    {
                        if ( ghService.FindGhByTenTK_MaS_MaKS(tk.TenTK, dv.Rows[i].Cells[1].Value.ToString(), cbKS.SelectedValue.ToString()) != null )
                        {
                            ghService.FindGhByTenTK_MaS_MaKS(tk.TenTK, dv.Rows[i].Cells[1].Value.ToString(), cbKS.SelectedValue.ToString()).SoLuong += 1;
                        } else
                        {
                            GioHang gh = new GioHang();
                            gh.TenTK = tk.TenTK;
                            gh.MaSach = sachService.findSachByID(dv.Rows[i].Cells[1].Value.ToString()).MaSach;
                            gh.MaKS = cbKS.SelectedValue.ToString();
                            gh.SoLuong = 1;
                            ghService.Add(gh);
                        }
                    }
                }
                ghService.Save();
                MessageBox.Show("Đã thêm vào giỏ hàng!"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbKS_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDataGrid(khoSachService.FindKsById(cbKS.SelectedValue.ToString())) ; 
            BindComboBoxTl();
        }

        private void gioHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formGH form = new formGH(taiKhoanService, tk, ghService);
            form.ShowDialog();

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTK form = new formTK(taiKhoanService,tk);
            form.ShowDialog();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            BindDataGrid(khoSachService.FindKsById(cbKS.SelectedValue.ToString()), tbSearch.Text, cbTL.SelectedValue.ToString());
        }

        private void cbTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDataGrid(khoSachService.FindKsById(cbKS.SelectedValue.ToString()),tbSearch.Text, cbTL.SelectedValue.ToString());   
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFeedback form = new formFeedback(tk);
            form.ShowDialog();
        }
    }
}
