using DAL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GioHangService
    {
        private Model1 context = new Model1();
        private GioHangRepo repo;

        public GioHangService()
        {
            this.repo = new GioHangRepo(context);
        }
        public void Remove ( GioHang gh )
        {
            repo.Remove( gh );
        }
        public void Add ( GioHang gh )
        {
            repo.Add(gh);
        }
        public void Save ()
        {
            repo.SaveChanges();
        }
        public GioHang FindGhByTenTK(string tentk)
        {
            return repo.GetGhByTenTK(tentk);
        }
        public GioHang FindGhByMs( string id )
        {
            return repo.GetGhByMs(id);
        }
        public List<GioHang> GetAllGh ()
        {
            return repo.GetAll();
        }
        public GioHang FindGhByTenTK_MaS_MaKS( string tentk , string masach, string maks )
        {
            return repo.GetGhByTenTK_MaS_MaKS(tentk, masach, maks);
        }
        public GioHang FindGhByTenTK_MaS(string tentk, string masach)
        {
            return repo.GetGhByTenTK_MaS(tentk, masach);
        }
    }
}
