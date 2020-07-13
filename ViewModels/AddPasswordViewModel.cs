using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModels
{
    public class AddPasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="New password")]
        public string NewPassword { get; set; }
        
        [DataType(DataType.Password)]
        [Display(Name ="Confirm your password")]
        [Compare("NewPassword",ErrorMessage ="The new password and confirm password do not match")]
        public string ConfirmPassword { get; set; }
    }
}
