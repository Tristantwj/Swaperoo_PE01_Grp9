using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Category
    {
        [Required(ErrorMessage = "Category ID is required")]
        [Display(Name = "Category ID")] 
        public int Id { get; set; }
        [Required(ErrorMessage = "Category Name is required")]
        [StringLength(255, MinimumLength = 0, ErrorMessage = "Category Name length should be between 0 and 255")] 
        public string Name { get; set; }
        
    }
}
