using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoursesManagment.BL.Models
{
    public class RegisterationVm
    {
        [Required(ErrorMessage ="Email is Required")]
        [EmailAddress(ErrorMessage ="Email Address is Invalid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [MinLength(6,ErrorMessage = "Email Address is Invalid")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [MinLength(6, ErrorMessage = "Email Address is Invalid")]
        [Compare("Password",ErrorMessage ="Confirm password isn't compatible")]
        public string confirmPassword { get; set; }
        [Required(ErrorMessage = "First Name is Required")]
        public string firstName { get; set; }
        [Required(ErrorMessage = "Last Name is Required")]
        public string lastName { get; set; }
        //public bool isAgree { get; set; }
    }
}
