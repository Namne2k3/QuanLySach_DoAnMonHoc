using DAL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietPhieuNhapService
    {
        public Model1 context = new Model1();
        private ChiTietPhieuNhapRepo repo;

        public ChiTietPhieuNhapService()
        {
            this.repo = new ChiTietPhieuNhapRepo(context);
        }
        public void Save()
        {
            repo.SaveChanges();
        }
        public List<ChiTiet_PN> FindCtPnByMaPn ( string mapn )
        {
            return repo.GetCtPnByMaPn(mapn);
        }
    }
}
