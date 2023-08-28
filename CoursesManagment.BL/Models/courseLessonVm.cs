using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagment.BL.Models
{
    public class courseLessonVm
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int orderNumber { get; set; }
        public int courseId { get; set; }
        public virtual CourseVm? course { get; set; }
        public string? fileName { get; set; }
        public string? filePath { get; set; }
        public IFormFile? Content { get; set; }
    }
}
