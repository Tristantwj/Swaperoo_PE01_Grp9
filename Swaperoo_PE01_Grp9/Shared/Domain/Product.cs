using System.ComponentModel.DataAnnotations;

namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public string? imagepath { get; set; }
        public double price { get; set; }
        public string status { get; set; }
        public string UserId { get; set; }
        public virtual User? User { get; set; }
        public int SubCategoryId { get; set; }
        public virtual SubCategory? SubCategory { get; set; }
        public virtual List<Chat>? Chats { get; set; }
    }

}
