using System;
using System.ComponentModel.DataAnnotations;

namespace AppointmentScheduling.Models.ViewModels
{
    public class RegisterViewModel
    {
        public RegisterViewModel()
        {
        }
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage ="The {0} must be at least {2} characters long.", MinimumLength =6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name="Confirm Password")]
        [Compare("Password", ErrorMessage ="The password and confirmation password doesn't not match!!!")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name="Role Name")]
        public string RoleName { get; set; }
    }
}
