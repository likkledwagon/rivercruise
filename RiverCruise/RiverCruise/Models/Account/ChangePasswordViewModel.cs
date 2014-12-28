using System.ComponentModel.DataAnnotations;
using ValidationResult = RiverCruise.Models.Shared.ValidationResult;

namespace RiverCruise.Models.Account
{
    public class ChangePasswordViewModel
    {
        public ValidationResult Validate()
        {
            var result = new ValidationResult();
            
            if (NewPassword.Equals(NewPasswordConfirm))
            {
                result.Valid = true;
            }
            else
            {
                result.Valid = false;
                result.ErrorMessages.Add("Passwords do not match");
            }

            return result;
        }

        [Display(Name = "Confirm new password")]
        [Required]
        public string NewPasswordConfirm { get; set; }

        [Display(Name = "New Password")]
        [Required]
        public string NewPassword { get; set; }

        [Display(Name = "Current password")]
        [Required]
        public string OldPassword { get; set; }

        public bool PasswordChanged { get; set; }
    }
}