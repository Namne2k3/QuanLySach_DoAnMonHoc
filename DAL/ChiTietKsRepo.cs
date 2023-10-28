using DAL.context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietKsRepo
    {
        private Model1 context;

        public List<ChiTiet_KS> GetCTKSById ( string id )
        {
            return context.ChiTiet_KS.Where(p => p.MaKS == id).ToList();        }
        public ChiTietKsRepo ( Model1 context)
        {
            this.context = context;
        }
        public int? GetSL( string maks , string masach )
        {
            return context.ChiTiet_KS.FirstOrDefault(p => p.MaSach == masach && p.MaKS == maks).Soluong;
        }
        public ChiTiet_KS GetCtks( string maks , string masach )
        {
            return context.ChiTiet_KS.FirstOrDefault(p => p.MaSach == masach && p.MaKS == maks);
        }
        public void Remove( ChiTiet_KS ks )
        {
            context.ChiTiet_KS.Remove(ks);
        }
        public void SaveChanges ()
        {
            context.SaveChanges();
        }
        public ChiTiet_KS GetKsByMaKS_MaS ( string maks , string masach )
        {
            return context.ChiTiet_KS.FirstOrDefault(p => p.MaKS == maks && p.MaSach == masach);
        }
        public DbContextTransaction BeginTransaction()
        {
            return context.Database.BeginTransaction();
        }
        public List<ChiTiet_KS> GetAll()
        {
            return context.ChiTiet_KS.ToList();
        }
    }
}
