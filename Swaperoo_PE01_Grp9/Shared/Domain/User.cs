using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Email { get; set; }
        public string? Description { get; set; }
        public string profilepicture { get; set; }
        public string Role { get; set; }
        
    }
}
