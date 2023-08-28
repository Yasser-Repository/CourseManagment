using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagment.BL.Models
{
    public class CourseVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime creationalDate { get; set; }
        public string Description { get; set; }
        public int categoryId { get; set; }
        public int trainerId { get; set; }
        public virtual CategoryVm? category { get; set; }
        public virtual TrainnerVm? trainer { get; set; }
       // public virtual IEnumerable<courseLessonVm>? courseLessons { get; set; }
        public virtual IEnumerable<TraineeVm>? Trainees { get; set; }


    }
}
