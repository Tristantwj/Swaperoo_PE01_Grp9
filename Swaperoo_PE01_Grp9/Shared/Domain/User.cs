using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class User : IValidatableObject
    {

        [Required(ErrorMessage = "User ID is required")]
        [Display(Name = "User ID")] 
        public int Id { get; set; }
        public string? UserId { get; set; }
        [Required(ErrorMessage = "User Name is required")]
        [StringLength(255, MinimumLength = 0, ErrorMessage = "User Name length should be between 0 and 255")] 
        public string Name { get; set; }

        [Required(ErrorMessage = "User Region is required")]
        public string Region { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "User Description is required")]
        [StringLength(255, MinimumLength = 0, ErrorMessage = "User Description length should be between 0 and 255")] 
        public string? Description { get; set; }
        public string profilepicture { get; set; }

        [Required(ErrorMessage = "User Role is required")] 
        public string Role { get; set; }
        [Required(ErrorMessage = "User Date Created is required")]
        [DataType(DataType.Date)] 
        public DateTime? DateCreated { get; set; }
        [Required(ErrorMessage = "User Date Updated is required")]
        [DataType(DataType.Date)] 
        public DateTime? DateUpdated { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            if (!string.IsNullOrWhiteSpace(profilepicture))
            {
                if (!Uri.TryCreate(profilepicture, UriKind.Absolute, out Uri uriResult) ||
                    (uriResult.Scheme != Uri.UriSchemeHttp && uriResult.Scheme != Uri.UriSchemeHttps))
                {
                    results.Add(new ValidationResult("Invalid image URL.", new[] { nameof(profilepicture) }));
                }
            }

            if (!string.IsNullOrWhiteSpace(Email) && !IsValidEmail(Email))
            {
                results.Add(new ValidationResult("Invalid email format", new[] { nameof(Email) }));
            }

            return results;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
