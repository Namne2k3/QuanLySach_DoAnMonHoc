using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTiet_HoaDonRepo
    {
        private Model1 context;
        public ChiTiet_HoaDonRepo(Model1 context)
        {
            this.context = context;
        }
        public List<ChiTiet_HD> GetCTHDByTK( TaiKhoan tk )
        {
            return null;
        }
        public List<ChiTiet_HD> GetListByMaHd( int mahd )
        {
            return context.ChiTiet_HD.Where( p => p.MaHD == mahd ).ToList();
        }
        public List<ChiTiet_HD> GetAll ()
        {
            return context.ChiTiet_HD.ToList();
        }
    }
}
