using System.ComponentModel.DataAnnotations;

namespace Mosh.Vidly.ViewModels.Authentication
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}