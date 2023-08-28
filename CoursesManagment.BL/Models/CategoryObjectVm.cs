using CourseManagment.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesManagment.BL.Models
{
    public class CategoryObjectVm
    {
        public IEnumerable<CategoryVm>? RecivedCategories { get; set; }
        public CategoryVm? SentCategorie { get; set; }
    }
}
