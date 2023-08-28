using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesManagment.BL.Models
{
    public class resetPasswordVm
    {
        [Required(ErrorMessage = "Password is Required")]
        [MinLength(6, ErrorMessage = "Email Address is Invalid")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [MinLength(6, ErrorMessage = "Email Address is Invalid")]
        [Compare("Password", ErrorMessage = "Confirm password isn't compatible")]
        public string confirmPassword { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
