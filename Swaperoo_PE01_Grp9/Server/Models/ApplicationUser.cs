using Microsoft.AspNetCore.Identity;
using Swaperoo_PE01_Grp9.Shared.Domain;

namespace Swaperoo_PE01_Grp9.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public string? Region { get; set; }

    }
}

