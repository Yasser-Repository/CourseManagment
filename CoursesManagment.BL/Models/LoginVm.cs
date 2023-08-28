using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoursesManagment.BL.Models
{
    public class LoginVm
    {
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Email Address is Invalid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [MinLength(6, ErrorMessage = "Email Address is Invalid")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
