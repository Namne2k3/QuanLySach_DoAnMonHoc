using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuNhapRepo
    {
        private Model1 context;

        public PhieuNhapRepo(Model1 context)
        {
            this.context = context;
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public void Add (PhieuNhap pn )
        {
            context.PhieuNhaps.Add( pn );
        }
        public List<PhieuNhap> GetAll ()
        {
            return context.PhieuNhaps.ToList();
        }
        public PhieuNhap GetById( string id )
        {
            return context.PhieuNhaps.FirstOrDefault(p => p.MaPN.ToString() == id);
        }
    }
}
