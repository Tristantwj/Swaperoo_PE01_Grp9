using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Product
    {
        
        [Required(ErrorMessage = "Product ID is required")]
        [Display(Name = "Product ID")] 
        public int Id { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(255, MinimumLength = 0, ErrorMessage = "Product Name length should be between 0 and 255")] 
        public string Name { get; set; }

        [Required(ErrorMessage = "Product Date Created is required")]
        [DataType(DataType.Date)] 
        public DateTime DateCreated { get; set; }
        
        [Required(ErrorMessage = "Product Description is required")]
        [StringLength(255, MinimumLength = 0, ErrorMessage = "Description length should be between 0 and 255")] 
        public string Description { get; set; }
        [Required(ErrorMessage = "Product Image Path is required")] 
        public string? imagepath { get; set; }

        [Required(ErrorMessage = "Product Price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Product Price must be greater than 0")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Product Price should have up to two decimal places")] 
        public double price { get; set; }

        [Required(ErrorMessage = "Product Status is required")]
        [StringLength(255, MinimumLength = 0, ErrorMessage = "Product Status should be between 0 and 255")] 
        public string status { get; set; }
        
        [Required(ErrorMessage = "User ID is required")]
        [Display(Name = "User ID")] 
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        [Required(ErrorMessage = "SubCategory ID is required")]
        [Display(Name = "SubCategory ID")] 
        public int? SubCategoryId { get; set; }
        public virtual SubCategory? SubCategory { get; set; }


    }
}
