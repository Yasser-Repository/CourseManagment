using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagment.DAL.Entities
{
    public class courseLesson
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int orderNumber { get; set; }
        public int courseId { get; set; }
        public virtual Course? course { get; set; }
        public string? fileName { get; set; }
        public string? filePath { get; set; }
    }
}
