using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class SubCategory
    {
        [Required(ErrorMessage = "SubCategory ID is required")]
        [Display(Name = "SubCategory ID")] 
        public int Id { get; set; }
        [Required(ErrorMessage = "SubCategory Name is required")]
        [Display(Name = "SubCategory Name")] 
        public string Name { get; set;}

        [Required(ErrorMessage = "Category ID is required")]
        [Display(Name = "Category ID")] 
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        
    }
}
