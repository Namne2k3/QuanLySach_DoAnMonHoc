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
    public partial class formPhieuNhap : Form
    {
        private PhieuNhapService pnService = new PhieuNhapService();
        private SachService sachService = new SachService();
        private ChiTietPhieuNhapService ctpnService = new ChiTietPhieuNhapService();
        public static formPhieuNhap instance;
        public formPhieuNhap()
        {
            InitializeComponent();
            instance = this;
            this.Load += FormPhieuNhap_Load;
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            BindComboboxMaPN(pnService.GetAllPn());
            //if (cbMaPN.SelectedValue != null )
            //{
            //    var findPN = pnService.FindById(cbMaPN.SelectedValue.ToString());
            //    BindGroupBox(findPN);
            //}
            //BindDataGrid();
        }

        public void BindComboboxMaPN ( List<PhieuNhap> listpn )
        {
            cbMaPN.DataSource = listpn;
            cbMaPN.DisplayMember = "MaPN";
            cbMaPN.ValueMember = "MaPN";
        }
        private void BindDataGrid ()
        {
            List<Sach> listSach = new List<Sach>();
            dtg.Rows.Clear();
            foreach (var item in ctpnService.FindCtPnByMaPn(cbMaPN.SelectedValue.ToString()))
            {
                int newRow = dtg.Rows.Add();
                dtg.Rows[newRow].Cells[0].Value = sachService.findSachByID(item.MaSach).MaSach;
                dtg.Rows[newRow].Cells[1].Value = sachService.findSachByID(item.MaSach).TenSach;
                dtg.Rows[newRow].Cells[2].Value = sachService.findSachByID(item.MaSach).TheLoai.TenTL;
                dtg.Rows[newRow].Cells[3].Value = sachService.findSachByID(item.MaSach).Giamua;
                dtg.Rows[newRow].Cells[4].Value = item.Soluong;
                dtg.Rows[newRow].Cells[5].Value = int.Parse(item.Soluong.ToString()) * int.Parse(sachService.findSachByID(item.MaSach).Giamua.ToString());
            }
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void BindGroupBox( PhieuNhap pn )
        {
            if ( pn != null )
            {
                tbDate.Text = pn.Ngaynhap.ToShortDateString();
                tbNcc.Text = pn.MaNCC;
                tbTT.Text = pn.ThanhTien.ToString();
            }
        }
        private void cbMaPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaPN.SelectedValue != null)
            {
                int index = cbMaPN.SelectedIndex;
                var findPN = pnService.FindById(cbMaPN.SelectedValue.ToString());
                if (findPN != null)
                {
                    BindGroupBox(findPN);
                }
                BindDataGrid();
            }
        }

        private void cbMaPN_Click(object sender, EventArgs e)
        {
            BindComboboxMaPN(pnService.GetAllPn());
        }

        private void formPhieuNhap_Load_1(object sender, EventArgs e)
        {

        }
    }
}
