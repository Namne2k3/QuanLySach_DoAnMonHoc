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
    public partial class formQuanTiTK : Form
    {
        private TaiKhoanService tkService = new TaiKhoanService();
        private HoaDonService hdService = new HoaDonService();
        private ChiTiet_HoaDonService cthdService = new ChiTiet_HoaDonService();
        public formQuanTiTK()
        {
            InitializeComponent();
        }
        private void BindDataGrid( List<TaiKhoan> listtk )
        {
            dtg.Rows.Clear();
            dtg.DataSource = listtk;
            dtg.Columns[3].Visible = false;
            dtg.Columns[4].Visible = false;
            dtg.Columns[5].Visible = false;
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;   
        }
        private void formQuanTiTK_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            BindDataGrid(tkService.GetAllTk());
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                tbTK.Text = dtg.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbMK.Text = dtg.Rows[e.RowIndex].Cells[1].Value.ToString();

                int? tong = 0;
                int? soluong = 0;
                foreach (var item in hdService.FindHDofTK(tbTK.Text))
                {
                    foreach ( var item2 in cthdService.FindAllCTHD() )
                    {
                        if ( item2.MaHD == item.MaHD )
                        {
                            soluong += item2.SoLuong;
                        }
                    }
                    tong += item.Thanhtien;
                }
                tbTT.Text = tong.ToString();
                tbSL.Text = soluong.ToString(); 
            }
        }

        private void cbMK_CheckedChanged(object sender, EventArgs e)
        {
            tbMK.UseSystemPasswordChar = !cbMK.Checked;
        }
    }
}
