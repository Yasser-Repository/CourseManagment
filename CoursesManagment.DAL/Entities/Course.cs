using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagment.DAL.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime creationalDate { get; set; }
        public string Description { get; set; }
        public int categoryId { get; set; }
        public int trainerId { get; set; }
        public virtual Category? category { get; set; }
        public virtual Trainner? trainer { get; set; }
        //public virtual IEnumerable<courseLesson>? courseLessons { get; set; }
        public virtual IEnumerable<Trainee>? Trainees { get; set; }


    }
}
