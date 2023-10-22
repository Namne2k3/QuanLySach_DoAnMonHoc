using DAL.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class feedbackRepo
    {
        private Model1 context;
        public feedbackRepo ( Model1 context )
        {
            this.context = context;
        }
        public List<Feedback> GetAll()
        {
            return context.Feedbacks.ToList();
        }
        public void Add ( Feedback feedback )
        {
            context.Feedbacks.Add( feedback );
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public Feedback GetFB( string tentk , string masach )
        {
            return context.Feedbacks.FirstOrDefault(p => p.TenTK == tentk && p.MaSach == masach );
        }
    }
}
