using DAL.context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanRepo
    {
        public Model1 context; 

        public TaiKhoanRepo(Model1 context)
        {
            this.context = context;
        }

        public List<TaiKhoan> GetAll()
        {
            return context.TaiKhoans.Where(p => p.TenTK != "admin").ToList();
        }
        public TaiKhoan GetTkByTenTk( string ten )
        {
            return context.TaiKhoans.FirstOrDefault(p => p.TenTK == ten);
        }
        public TaiKhoan GetTkByEmail ( string email )
        {
            return context.TaiKhoans.FirstOrDefault(p => p.Email == email);
        }
        public void Remove( TaiKhoan tai )
        {
            context.TaiKhoans.Remove(tai);
        }
        public void Add( TaiKhoan tk )
        {
            context.TaiKhoans.Add( tk );
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public DbContextTransaction BeginTransaction()
        {
            return context.Database.BeginTransaction();
        }
    }
}
