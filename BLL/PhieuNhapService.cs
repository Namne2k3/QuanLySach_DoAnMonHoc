using DAL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuNhapService
    {
        public Model1 context = new Model1();
        private PhieuNhapRepo repo;

        public PhieuNhapService()
        {
            this.repo = new PhieuNhapRepo(context);
        }
        public void Save()
        {
            repo.SaveChanges();
        }
        public void AddPn( PhieuNhap pn )
        {
            repo.Add(pn);
        }
        public PhieuNhap FindById ( string id )
        {
            return repo.GetById(id);
        }
        public List<PhieuNhap> GetAllPn()
        {
            return repo.GetAll();
        }
    }
}
