using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
namespace Telefon_Rehberi.ViewModels
{
    public class EmployeeCreateViewModel
    {
        [Required]
        [MaxLength(20, ErrorMessage = "İsim 20 karakterden fazla olamaz")]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public IFormFile Photo { get; set; }
    }
}
