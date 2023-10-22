using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietPhieuNhapRepo
    {
        private Model1 context;

        public ChiTietPhieuNhapRepo(Model1 context)
        {
            this.context = context;
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public List<ChiTiet_PN> GetCtPnByMaPn( string mapn )
        {
            return context.ChiTiet_PN.Where(p => p.MaPN.ToString() == mapn).ToList();
        }
    }
}
