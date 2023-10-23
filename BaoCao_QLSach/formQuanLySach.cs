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
    public partial class formQuanLySach : Form
    {
        public KhoSachService khoSachService = new KhoSachService();
        public SachService sachService = new SachService();
        public KhoSachNccService khosachNccService = new KhoSachNccService();
        public NhaCungCapService nhaCungCapService = new NhaCungCapService();
        public ChiTietKsService chiTietKsService;

        public formNhapSach formNhapSach;
        public formQuanLySach(ChiTietKsService ctksService )
        {
            InitializeComponent();
            this.chiTietKsService = ctksService;
        }

        private void BindComboBoxKS()
        {
            cbKS.DataSource = khoSachService.GetAllKS();
            cbKS.DisplayMember = "TenKS";
            cbKS.ValueMember = "MaKS";
        }
        private void BindDataGrid(KhoSach ks, string search = null)
        {
            if (ks != null)
            {
                if (search != null)
                {
                    dtKS.Rows.Clear();
                    foreach (var item in chiTietKsService.GetAllCtKs())
                    {
                        if (item.MaKS == ks.MaKS)
                        {
                            if (sachService.findSachByID(item.MaSach).TenSach.ToLower().Contains(search.ToLower()))
                            {
                                int newRow = dtKS.Rows.Add();
                                dtKS.Rows[newRow].Cells[0].Value = sachService.findSachByID(item.MaSach).MaSach;
                                dtKS.Rows[newRow].Cells[1].Value = sachService.findSachByID(item.MaSach).TenSach;
                                dtKS.Rows[newRow].Cells[2].Value = sachService.findSachByID(item.MaSach).TheLoai.TenTL;

                                string mancc = khosachNccService.FindKsNccByMs(sachService.findSachByID(item.MaSach).MaSach).MaNCC;
                                dtKS.Rows[newRow].Cells[3].Value = nhaCungCapService.FindById(mancc).TenNCC;
                                dtKS.Rows[newRow].Cells[4].Value = sachService.findSachByID(item.MaSach).Giamua;
                                dtKS.Rows[newRow].Cells[5].Value = sachService.findSachByID(item.MaSach).Giaban;


                                dtKS.Rows[newRow].Cells[6].Value = chiTietKsService.FindSlBy(ks.MaKS, item.MaSach);
                            }
                        }
                    }
                    dtKS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    dtKS.Rows.Clear();
                    foreach (var item in chiTietKsService.GetAllCtKs())
                    {
                        if (item.MaKS == ks.MaKS)
                        {
                            int newRow = dtKS.Rows.Add();
                            dtKS.Rows[newRow].Cells[0].Value = sachService.findSachByID(item.MaSach).MaSach;
                            dtKS.Rows[newRow].Cells[1].Value = sachService.findSachByID(item.MaSach).TenSach;
                            dtKS.Rows[newRow].Cells[2].Value = sachService.findSachByID(item.MaSach).TheLoai.TenTL;

                            string mancc = khosachNccService.FindKsNccByMs(sachService.findSachByID(item.MaSach).MaSach).MaNCC;
                            dtKS.Rows[newRow].Cells[3].Value = nhaCungCapService.FindById(mancc).TenNCC;
                            dtKS.Rows[newRow].Cells[4].Value = sachService.findSachByID(item.MaSach).Giamua;
                            dtKS.Rows[newRow].Cells[5].Value = sachService.findSachByID(item.MaSach).Giaban;


                            dtKS.Rows[newRow].Cells[6].Value = chiTietKsService.FindSlBy(ks.MaKS, item.MaSach);
                        }
                    }
                    dtKS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }
       
        private void cbKS_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            BindDataGrid(khoSachService.FindKsById(cbKS.SelectedValue.ToString()));
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            BindDataGrid(khoSachService.FindKsById(cbKS.SelectedValue.ToString()), tbSearch.Text);
        }

        private void dtKS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                tbMa.Text = dtKS.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbTen.Text = dtKS.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbTL.Text = dtKS.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbGM.Text = dtKS.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbGB.Text = dtKS.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbSL.Text = dtKS.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbNCC.Text = dtKS.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
 
        private void Clear()
        {
            tbMa.Text = "";
            tbTen.Text = "";
            tbTL.Text = "";
            tbGM.Text = "";
            tbGB.Text = "";
            tbSL.Text = "";
            tbNCC.Text = "";
        }
        private void formQuanLySach_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            BindComboBoxKS();
            BindDataGrid(khoSachService.FindKsById(cbKS.SelectedValue.ToString()));
        }

        private void btDelete_Click_1(object sender, EventArgs e)
        {
            using (var transaction = chiTietKsService.BeginTransaction())
            {
                try
                {
                    var findKsMs = chiTietKsService.FindKsks(khoSachService.FindKsById(cbKS.SelectedValue.ToString()).MaKS, tbMa.Text);
                    if (findKsMs != null)
                    {
                        chiTietKsService.Delete(findKsMs);
                        chiTietKsService.Save();
                        BindDataGrid(khoSachService.FindKsById(cbKS.SelectedValue.ToString()));
                        Clear();
                        MessageBox.Show("Da xoa!");
                    }
                    else
                    {
                        throw new Exception("Khong tim thay sach can xoa!");
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            BindDataGrid(khoSachService.FindKsById(cbKS.SelectedValue.ToString()));
        }
    }
}
