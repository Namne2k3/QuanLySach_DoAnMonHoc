using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SachRepo
    {
        public Model1 context;

        public SachRepo(Model1 context)
        {
            this.context = context;
        }
        public Sach GetById ( string id )
        {
            return context.Saches.FirstOrDefault(p => p.MaSach == id);
        }
        public List<Sach> GetAll()
        {
            return context.Saches.ToList();
        }
    }
}
