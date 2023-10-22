using DAL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanService
    {
        Model1 context = new Model1();
        private TaiKhoanRepo repo;

        public TaiKhoanService()
        {
            this.repo = new TaiKhoanRepo(context);
        }
        public List<TaiKhoan> GetAllTk ()
        {
            return repo.GetAll();
        }
        public TaiKhoan FindTkByTenTk( string ten )
        {
            return repo.GetTkByTenTk(ten);
        }
        public TaiKhoan FindTkByEmail ( string email )
        {
            return repo.GetTkByEmail(email);
        }
        public void InsertTK( TaiKhoan tk)
        {
            repo.Add(tk);
        }
        public void Save()
        {
            repo.SaveChanges();
        }

        public DbContextTransaction BeginTransaction ()
        {
            return repo.BeginTransaction();
        }

        
    }
}
