using BLL;
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
    public partial class formDoanhThu : Form
    {
        public HoaDonService hdService = new HoaDonService();
        public formDoanhThu()
        {
            InitializeComponent();
        }

        private void calender_DateChanged(object sender, DateRangeEventArgs e)
        {
            BindTbDate();
            BindTbDt();
        }
        private void BindTbDt()
        {
            int doanhthu = 0;
            foreach ( var item in hdService.FindAllHd() )
            {
                if ( item.Ngaylap.ToShortDateString() == tbDate.Text )
                {
                    doanhthu += int.Parse(item.Thanhtien.ToString());
                }
            }
            tbDT.Text = doanhthu.ToString();
        }
        private void BindTbDate()
        {
            tbDate.Text = calender.SelectionStart.ToShortDateString();
        }
        private void formDoanhThu_Load(object sender, EventArgs e)
        {
            tbDate.Text = calender.TodayDate.ToShortDateString();
            BindTbDate();
            BindTbDt();
        }
    }
}
