using System.ComponentModel.DataAnnotations;

<<<<<<< Updated upstream
namespace Telefon_Rehberi.ViewModels
=======
namespace EmployeeManagement.ViewModels
>>>>>>> Stashed changes
{
    public class LoginViewModel
    {
       [Required]
       [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Remember me?")]
        public bool RememberMe { get; set; }
    }
}
