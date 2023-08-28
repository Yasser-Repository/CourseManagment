using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace CoursesManagment.BL.Models
{
    public class ForgetPasswordVm
    {
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Email Address is Invalid")]
        public string Email { get; set; }
    }
}
