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
    public partial class formCT_HD : Form
    {
        private HoaDon hd;
        private ChiTiet_HoaDonService chiTiet_HoaDonService = new ChiTiet_HoaDonService();
        private SachService sachService = new SachService();
        public string masach;
        public formCT_HD(HoaDon hd)
        {
            InitializeComponent();
            this.hd = hd;
        }
        private void BindDataGrid()
        {
            //chiTiet_HoaDonService.FindListByMaHd(hd.MaHD);
            foreach (var item in chiTiet_HoaDonService.FindListByMaHd(hd.MaHD))
            {
                var findSach = sachService.findSachByID(item.MaSach);
                int newRow = dg.Rows.Add();
                dg.Rows[newRow].Cells[0].Value = findSach.MaSach;
                dg.Rows[newRow].Cells[1].Value = findSach.TenSach;
                dg.Rows[newRow].Cells[2].Value = item.SoLuong;
                dg.Rows[newRow].Cells[3].Value = item.SoLuong * findSach.Giaban;
            }
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void formCT_HD_Load(object sender, EventArgs e)
        {
            tbMaHD.Text = hd.MaHD.ToString();
            tbTT.Text = hd.Thanhtien.ToString();
            tbDate.Text = hd.Ngaylap.ToShortDateString();

            BindDataGrid();
        }
    }
}
