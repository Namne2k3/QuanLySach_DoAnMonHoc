using DAL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhoSachNccService
    {
        public Model1 context = new Model1();
        private KhoSachNccRepo repo;

        public KhoSachNccService()
        {
            this.repo = new KhoSachNccRepo(context);
        }
        public KhoSachNCC FindKsNccByMs ( string masach )
        {
            return repo.GetKsNccByMs( masach );
        }
        public List<KhoSachNCC> FindSachsByNcc ( string mancc )
        {
            return repo.GetSachsByNcc(mancc);
        }
        public int? FindSoLuong ( string mancc , string masash )
        {
            return repo.GetSoLuong(mancc, masash);
        }
    }
}
