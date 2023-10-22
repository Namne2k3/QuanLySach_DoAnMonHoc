using DAL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaCungCapService
    {
        Model1 context = new Model1();
        private NhaCungCapRepo repo;

        public NhaCungCapService()
        {
            this.repo = new NhaCungCapRepo(context);
        }

        public List<NhaCungCap> GetAllNcc ()
        {
            return repo.GetAll();
        }
        public NhaCungCap FindById( string id )
        {
            return repo.GetById( id );
        }
        public void Save()
        {
            repo.SaveChanges();
        }
    }
}
