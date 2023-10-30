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
    public partial class formAdmin : Form
    {

        public formNhapSach formNS;
        public formQuanLySach formQuanLySach;
        public formPhieuNhap formPhieuNhap;
        public formQuanTiTK formQuanTiTK;
        public formDoanhThu formDoanhThu;
        public formQuanLyFB formQLFB;
        public ChiTietKsService ctksService = new ChiTietKsService();
        
        public formAdmin()
        {
            InitializeComponent();
            mdiProp();
        }
        private void mdiProp()
        {
            this.SetBevel(false);
        }
        bool menuExpand = true;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if ( menuExpand == false )
            {
                menuContainer.Height += 10;
                if ( menuContainer.Height >= 338) 
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            } else
            {
                menuContainer.Height -= 10;
                if ( menuContainer.Height <= 54 )
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 62)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 180)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            if (formNS == null )
            {
                formNS = new formNhapSach(ctksService);
                formNS.FormClosed += FormNhapSach_FormClosed;
                formNS.MdiParent = this;
                formNS.Dock = DockStyle.Fill;
                formNS.Show();
            } else
            {
                formNS.Activate();
            }
        }

        private void FormNhapSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            formNS = null;
        }

        private void btQlSach_Click(object sender, EventArgs e)
        {
            if ( formQuanLySach == null )
            {
                formQuanLySach = new formQuanLySach(ctksService);
                formQuanLySach.FormClosed += FormQuanLySach_FormClosed;
                formQuanLySach.MdiParent = this; 
                formQuanLySach.Dock = DockStyle.Fill;
                formQuanLySach.Show();
            } else
            {
                formQuanLySach.Activate();
            }
        }
        private void btPn_Click(object sender, EventArgs e)
        {
            if ( formPhieuNhap == null )
            {
                formPhieuNhap = new formPhieuNhap();
                formPhieuNhap.FormClosed += FormPhieuNhap_FormClosed;
                formPhieuNhap.MdiParent = this;
                formPhieuNhap.Dock = DockStyle.Fill;
                formPhieuNhap.Show();
            } else
            {
                formPhieuNhap.Activate();
            }
        }
        private void btQlTk_Click(object sender, EventArgs e)
        {
            if (formQuanTiTK == null )
            {
                formQuanTiTK = new formQuanTiTK();
                formQuanTiTK.FormClosed += FormQuanTiTK_FormClosed;
                formQuanTiTK.MdiParent = this;
                formQuanTiTK.Dock = DockStyle.Fill;
                formQuanTiTK.Show();
            } else
            {
                formQuanTiTK.Activate();
            }
        }
        private void btDT_Click(object sender, EventArgs e)
        {
            if ( formDoanhThu == null )
            {
                formDoanhThu = new formDoanhThu();
                formDoanhThu.FormClosed += FormDoanhThu_FormClosed;
                formDoanhThu.MdiParent = this;
                formDoanhThu.Dock = DockStyle.Fill;
                formDoanhThu.Show();
            }
            else
            {
                formDoanhThu.Activate();
            }
        }
        private void btFB_Click(object sender, EventArgs e)
        {
            if (formQLFB == null)
            {
                formQLFB = new formQuanLyFB();
                formQLFB.FormClosed += FormQLFB_FormClosed;
                formQLFB.MdiParent = this;
                formQLFB.Dock = DockStyle.Fill;
                formQLFB.Show();
            }
            else
            {
                formQLFB.Activate();
            }
        }

        private void FormQLFB_FormClosed(object sender, FormClosedEventArgs e)
        {
            formQLFB = null;
        }

        private void FormDoanhThu_FormClosed(object sender, FormClosedEventArgs e)
        {
            formDoanhThu = null;
        }
    

        private void FormQuanTiTK_FormClosed(object sender, FormClosedEventArgs e)
        {
            formQuanTiTK = null;
        }

        private void FormPhieuNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPhieuNhap = null;
        }

        private void FormQuanLySach_FormClosed(object sender, FormClosedEventArgs e)
        {
            formQuanLySach = null;
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Đã đăng xuất!");
        }
    }
}
