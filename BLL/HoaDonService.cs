using DAL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonService
    {
        Model1 context = new Model1();
        private HoaDonRepo repo;
        public HoaDonService()
        {
            this.repo = new HoaDonRepo(context);
        }
        public List<HoaDon> FindAllHd()
        {
            return repo.GetAll();
        }
        public HoaDon FindHdByMaHd ( int mahd )
        {
            return repo.GetHdByMaHd( mahd );
        }
        public List<HoaDon> FindHDofTK ( string tentk )
        {
            return repo.GetHdOfTK(tentk);
        }
    }
}
