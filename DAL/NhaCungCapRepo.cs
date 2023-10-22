using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCapRepo
    {
        public Model1 context;

        public NhaCungCapRepo(Model1 context)
        {
            this.context = context;
        }

        public List<NhaCungCap> GetAll ()
        {
            return context.NhaCungCaps.ToList();
        }
        public NhaCungCap GetById ( string id )
        {
            return context.NhaCungCaps.FirstOrDefault(p => p.MaNCC == id);
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
