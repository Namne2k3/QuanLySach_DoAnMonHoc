using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GioHangRepo
    {
        public Model1 context; 

        public GioHangRepo(Model1 context)
        {
            this.context = context;
        }
        public void Remove( GioHang gh )
        {
            context.GioHangs.Remove( gh );
        }
        public void Add ( GioHang gh )
        {
            context.GioHangs.Add( gh );
        }
        public GioHang GetGhByTenTK ( string tentk )
        {
            return context.GioHangs.FirstOrDefault(p => p.TenTK == tentk);
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public GioHang GetGhByMs ( string id )
        {
            return context.GioHangs.FirstOrDefault(p => p.MaSach == id);
        }
        public List<GioHang> GetAll()
        {
            return context.GioHangs.ToList();
        }
        public GioHang GetGhByTenTK_MaS_MaKS ( string tentk , string masach, string maks )
        {
            return context.GioHangs.FirstOrDefault(p => p.TenTK == tentk && p.MaSach == masach && p.MaKS == maks);
        }
        public GioHang GetGhByTenTK_MaS(string tentk, string masach)
        {
            return context.GioHangs.FirstOrDefault(p => p.TenTK == tentk && p.MaSach == masach);
        }
    }
}
