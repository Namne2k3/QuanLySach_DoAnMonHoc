using DAL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TheLoaiService
    {
        public Model1 context = new Model1();
        private TheLoaiRepo repo;

        public TheLoaiService()
        {
            this.repo = new TheLoaiRepo(context);
        }
        public List<TheLoai> GetAllTl()
        {
            return repo.GetAll();
        }
    }
}
