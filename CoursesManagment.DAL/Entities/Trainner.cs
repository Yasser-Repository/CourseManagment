using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagment.DAL.Entities
{
    public class Trainner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public DateTime creeationalDate { get; set; }
        public string Description { get; set; }
        public bool isActive { get; set; }
        //public virtual IEnumerable<Course>? courses { get; set; }
    }
}
