using DAL;
using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class feedbackService
    {
        public Model1 context = new Model1();
        private feedbackRepo repo;
        public feedbackService()
        {
            this.repo = new feedbackRepo(context);
        }
        public List<Feedback> FindAllFb()
        {
            return repo.GetAll();
        }
        public void Add ( Feedback fb )
        {
            repo.Add(fb);
        }
        public void Save()
        {
            repo.SaveChanges();
        }
        public Feedback FindFb ( string tentk , string masach )
        {
            return repo.GetFB( tentk , masach );
        }
    }
}
