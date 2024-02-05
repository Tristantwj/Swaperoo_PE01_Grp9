using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Rating
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Rating Value is required")]
        [Display(Name = "Rating Value")]
        public int RatingValue { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Rating Date Created is required")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
        [Required(ErrorMessage = "User ID is required")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public int? PurchaseId { get; set; }
        public virtual Purchase? Purchase { get; set; }
        public int? SwapId { get; set; }
        public virtual Swap? Swap { get; set;}
    }
}
