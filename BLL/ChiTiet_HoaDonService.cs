using DAL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTiet_HoaDonService
    {
        public Model1 context = new Model1();
        private ChiTiet_HoaDonRepo repo;
        public ChiTiet_HoaDonService() 
        {
            this.repo = new ChiTiet_HoaDonRepo(context);
        }
        public List<ChiTiet_HD> FindCTHDByTK ( TaiKhoan tk )
        {
            return repo.GetCTHDByTK(tk);
        }
        public List<ChiTiet_HD> FindListByMaHd( int mahd )
        {
            return repo.GetListByMaHd( mahd );
        }
        public List<ChiTiet_HD> FindAllCTHD()
        {
            return repo.GetAll();
        }
    }
}
