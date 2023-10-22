using DAL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhoSachService
    {
        Model1 context = new Model1();
        private KhoSachRepo repo;

        public KhoSachService()
        {
            this.repo = new KhoSachRepo(context);
        }
        public KhoSach FindKsById ( string id )
        {
            return repo.GetByMaKS(id);
        }
        public List<KhoSach> GetAllKS()
        {
            return repo.GetAll();
        }
        public void Save()
        {
            repo.SaveChanges();
        }
    }
}
