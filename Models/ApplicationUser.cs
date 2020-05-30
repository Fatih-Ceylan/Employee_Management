using Microsoft.AspNetCore.Identity;
namespace Telefon_Rehberi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
    }
}
