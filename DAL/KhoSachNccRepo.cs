using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhoSachNccRepo
    {
        private Model1 context;

        public KhoSachNccRepo(Model1 context)
        {
            this.context = context;
        }

        public KhoSachNCC GetKsNccByMs( string masach )
        {
            return context.KhoSachNCCs.FirstOrDefault(p => p.MaSach == masach);
        }
        public List<KhoSachNCC> GetSachsByNcc(string mancc)
        {
            return context.KhoSachNCCs.Where(p => p.MaNCC == mancc).ToList();
        }
        public int? GetSoLuong(string mancc , string masach )
        {
            return context.KhoSachNCCs.FirstOrDefault(p => p.MaNCC == mancc && p.MaSach == masach).Soluong;
        }
    }
}
