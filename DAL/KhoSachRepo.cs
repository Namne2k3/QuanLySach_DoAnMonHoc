using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhoSachRepo
    {
        public Model1 context; 

        public KhoSachRepo(Model1 context)
        {
            this.context = context;
        }
        public List<KhoSach> GetAll()
        {
            return context.KhoSaches.ToList();
        }
        public KhoSach GetByMaKS( string id )
        {
            return context.KhoSaches.FirstOrDefault(p => p.MaKS == id);
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
