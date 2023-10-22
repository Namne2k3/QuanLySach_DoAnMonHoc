using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TheLoaiRepo
    {
        private Model1 context;
        public TheLoaiRepo( Model1 context )
        {
            this.context = context;
        }
        public List<TheLoai> GetAll()
        {
            return context.TheLoais.ToList();
        }
    }
}
