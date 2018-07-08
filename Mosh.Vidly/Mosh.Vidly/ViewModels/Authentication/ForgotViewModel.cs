using System.ComponentModel.DataAnnotations;

namespace Mosh.Vidly.ViewModels.Authentication
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}