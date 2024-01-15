using Microsoft.AspNetCore.Identity;

namespace Swaperoo_PE01_Grp9.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public string Region { get; set; }
    }
}