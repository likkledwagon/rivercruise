using System.ComponentModel.DataAnnotations;

namespace RiverCruise.Models.UserManagement
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm password")]
        [Display(Name="Confirm password")]
        public string PasswordConfirm { get; set; }

        [Display(Name="Can edit")]
        public bool CanEdit { get; set; }
    }
}