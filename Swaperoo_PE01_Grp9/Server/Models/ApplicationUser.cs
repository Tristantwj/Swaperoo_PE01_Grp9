using Microsoft.AspNetCore.Identity;

namespace Swaperoo_PE01_Grp9.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}