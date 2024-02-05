using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Purchase
    {
        [Required(ErrorMessage = "Category ID is required")]
        [Display(Name = "Category ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Purchase Sell Date is required")]
        [DataType(DataType.Date)]
        public DateTime SellDate { get; set; }
        [Required(ErrorMessage = "Offer Price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Offer Price must be greater than 0")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Offer Price should have up to two decimal places")] 
        public double OfferPrice { get; set; }

        public string? Status { get; set; }

        public int? UserId { get; set; }
        public virtual User? User { get; set; }

        [Required(ErrorMessage = "Purchase Product ID is required")]
        [Display(Name = "Purchase Product ID")] 
        public int? PurchaseProductId { get; set; }
        public virtual Product? PurchaseProduct { get; set; }
    }
}
