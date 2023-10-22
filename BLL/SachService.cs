using DAL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SachService
    {
        Model1 context = new Model1();
        private SachRepo repo;

        public SachService()
        {
            this.repo = new SachRepo(context);
        }
        public Sach findSachByID ( string id )
        {
            return repo.GetById(id);
        }
        public List<Sach> FindAllSach()
        {
            return repo.GetAll();
        }
    }
}
