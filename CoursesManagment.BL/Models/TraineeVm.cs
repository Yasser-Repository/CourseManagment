﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagment.BL.Models
{
    public class TraineeVm
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name Is Required")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }
        public virtual IEnumerable<CourseVm>? Courses { get; set; }

    }
}
