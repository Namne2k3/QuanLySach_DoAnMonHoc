using DAL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietKsService
    {
        public Model1 context = new Model1();
        private ChiTietKsRepo repo;

        public ChiTietKsService()
        {
            this.repo = new ChiTietKsRepo(context);
        }
        public List<ChiTiet_KS> FindCTKSByID( string id )
        {
            return repo.GetCTKSById(id);
        }
        public int? FindSlBy( string maks, string masach )
        {
            return repo.GetSL(maks, masach);
        }
        public ChiTiet_KS FindKsks ( string maks, string masach )
        {
            return repo.GetCtks(maks, masach);
        }
        public void Delete( ChiTiet_KS ks )
        {
            repo.Remove(ks);
        }
        public void Save()
        {
            repo.SaveChanges();
        }
        public DbContextTransaction BeginTransaction()
        {
            return repo.BeginTransaction();
        }
        public List<ChiTiet_KS> GetAllCtKs ()
        {
            return repo.GetAll();
        }
        public ChiTiet_KS FindKsByMaKS_MaS ( string maks , string masach )
        {
            return repo.GetKsByMaKS_MaS(maks, masach);
        }
    }
}
