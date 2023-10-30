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
    public partial class formNhapSach : Form
    {
        private NhaCungCapService nhaCcService = new NhaCungCapService();
        private SachService sachService = new SachService();
        private KhoSachNccService khoSachNccService = new KhoSachNccService();
        private KhoSachService ksService = new KhoSachService();
        private ChiTietKsService ctksService;
        private PhieuNhapService pnService = new PhieuNhapService();
        private ChiTietPhieuNhapService ctpnService = new ChiTietPhieuNhapService();
        public formNhapSach( ChiTietKsService ctksService )
        {
            InitializeComponent();
            this.ctksService = ctksService;
        }
        private void BindComboboxKS ()
        {
            cbKS.DataSource = ksService.GetAllKS();
            cbKS.DisplayMember = "TenKS";
            cbKS.ValueMember = "MaKS";
        }
        private void BindComboboxNcc ()
        {
            cbNcc.DataSource = nhaCcService.GetAllNcc();
            cbNcc.DisplayMember = "TenNCC";
            cbNcc.ValueMember = "MaNCC";
            cbNcc.SelectedIndex = 0;
        }
        private void BindDataGrid( List<Sach> list )
        {
            dtg.Rows.Clear();
            foreach ( var sach in list )
            {
                if ( sach != null )
                {
                    int newRow = dtg.Rows.Add();
                    dtg.Rows[newRow].Cells[1].Value = sach.MaSach;
                    dtg.Rows[newRow].Cells[2].Value = sach.TenSach;
                    dtg.Rows[newRow].Cells[3].Value = sach.Giamua;
                    dtg.Rows[newRow].Cells[4].Value = sach.TheLoai.TenTL;
                    dtg.Rows[newRow].Cells[5].Value = khoSachNccService.FindSoLuong(cbNcc.SelectedValue.ToString(), sach.MaSach);
                    dtg.Rows[newRow].Cells[6].Value = 1;
                }
            }
            dtg.Columns[5].Visible = false;
            foreach (DataGridViewRow row in dtg.Rows)
            {
                row.Cells["colSelect"].Value = 0;
            }
            dtg.Columns[6].DefaultCellStyle.BackColor = Color.Orange;
        }
        private void formNhapSach_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn checkCol = new DataGridViewCheckBoxColumn();
            checkCol.Name = "colSelect";
            checkCol.HeaderText = "Select";
            checkCol.Width = 50;
            checkCol.ReadOnly = false;
            checkCol.TrueValue = 1;
            checkCol.FalseValue = 0;
            dtg.Columns.Insert(0, checkCol);
            BindComboboxNcc();
            BindComboboxKS();

            List<Sach> tempList = new List<Sach>();
            foreach (var item in khoSachNccService.FindSachsByNcc(cbNcc.SelectedValue.ToString()))
            {
                if (item != null)
                {
                    tempList.Add(sachService.findSachByID(item.MaSach));
                }
            }
            BindDataGrid(tempList);
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbDate.Text = DateTime.Now.ToString();
        }
        private void Clear()
        {
            tbTT.Text = "";
        }
        private void cbNcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Sach> tempList = new List<Sach>();
            foreach (var item in khoSachNccService.FindSachsByNcc(cbNcc.SelectedValue.ToString()))
            {
                if (item != null)
                {
                    tempList.Add(sachService.findSachByID(item.MaSach));
                }
            }
            BindDataGrid(tempList);
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            try
            {
                int soluong = 0;
                int giatien = 0;

                PhieuNhap pn = new PhieuNhap();
                pn.Ngaynhap = DateTime.Parse(tbDate.Text);
                pn.MaNCC = cbNcc.SelectedValue.ToString();

                for (int i = 0; i < dtg.Rows.Count; i++)
                {
                    if (dtg.Rows[i].Cells[0].Value.ToString() == "1")
                    {
                        if ( ctksService.FindKsks(cbKS.SelectedValue.ToString(), dtg.Rows[i].Cells[1].Value.ToString()) != null ) 
                        {
                            ChiTiet_PN ct = new ChiTiet_PN();
                            ctksService.FindKsks(cbKS.SelectedValue.ToString(), dtg.Rows[i].Cells[1].Value.ToString()).Soluong += int.Parse(dtg.Rows[i].Cells[6].Value.ToString());
                            ct.MaSach = dtg.Rows[i].Cells[1].Value.ToString();
                            ct.Soluong = int.Parse(dtg.Rows[i].Cells[6].Value.ToString());
                            pn.ChiTiet_PN.Add(ct);
                            soluong = int.Parse(dtg.Rows[i].Cells[6].Value.ToString());
                            giatien += (int.Parse(dtg.Rows[i].Cells[6].Value.ToString()) * int.Parse(dtg.Rows[i].Cells[3].Value.ToString()));
                            ctksService.Save();
                        }
                        else
                        {
                            ChiTiet_PN ct = new ChiTiet_PN();
                            ChiTiet_KS ctks = new ChiTiet_KS();

                            ctks.MaKS = cbKS.SelectedValue.ToString();
                            ctks.MaSach = dtg.Rows[i].Cells[1].Value.ToString();
                            ctks.Soluong = int.Parse(dtg.Rows[i].Cells[6].Value.ToString());

                            ct.MaSach = dtg.Rows[i].Cells[1].Value.ToString();
                            ct.Soluong = int.Parse(dtg.Rows[i].Cells[6].Value.ToString());
                            soluong = int.Parse(dtg.Rows[i].Cells[6].Value.ToString());
                            giatien += (int.Parse(dtg.Rows[i].Cells[6].Value.ToString()) * int.Parse(dtg.Rows[i].Cells[3].Value.ToString()));
                            pn.ChiTiet_PN.Add(ct);
                            ksService.FindKsById(cbKS.SelectedValue.ToString()).ChiTiet_KS.Add(ctks);
                        }
                    }
                }

                if ( soluong != 0 )
                {
                    tbTT.Text = giatien.ToString();
                    pn.ThanhTien = int.Parse(tbTT.Text);

                    DialogResult result = MessageBox.Show("Tiến hành nhập sách", "Bạn có muốn xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        nhaCcService.FindById(cbNcc.SelectedValue.ToString()).PhieuNhaps.Add(pn);
                        nhaCcService.Save();
                        ksService.Save();
                        MessageBox.Show("Nhap sach hoan tat!" + "\n" + "Ma phieu nhap: " + pn.MaPN);
                        Clear();
                    }
                }
                else
                {
                    throw new Exception("Phiếu nhập trống!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( e.RowIndex != -1 )
            {
                if ( e.ColumnIndex == 0 )
                {
                    tbTT.Text = "";
                }
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
        private void dtg_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);

            // Check if the current column is the desired one
            if (dtg.CurrentCell.ColumnIndex == 6) // Change 0 to your column index
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
