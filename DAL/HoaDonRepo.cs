using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonRepo
    {
        public Model1 context; 

        public HoaDonRepo(Model1 context)
        {
            this.context = context;
        }
        public List<HoaDon> GetAll()
        {
            return context.HoaDons.ToList();
        }
        public HoaDon GetHdByMaHd( int mahd )
        {
            return context.HoaDons.FirstOrDefault(p => p.MaHD == mahd);
        }
        public List<HoaDon> GetHdOfTK ( string tentk )
        {
            return context.HoaDons.Where(p => p.TenTK == tentk).ToList();
        }
    }
}
