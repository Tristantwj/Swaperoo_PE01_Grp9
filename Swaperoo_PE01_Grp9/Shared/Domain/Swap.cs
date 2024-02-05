using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Swap
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Swap Date is required")]
        [DataType(DataType.Date)]
        public DateTime SwapDate { get; set; }
        public string? BuyerStatus { get; set; }
        public string? SellerStatus { get; set; }
        [Required(ErrorMessage = "Offer Item is required")]
        [Display(Name = "Offer Item ID")]
        public int? OfferItemId { get; set; }
        public virtual Product? OfferItem { get; set; }
        public int? SwapProductId { get; set; }
        public virtual Product? SwapProduct { get; set; }
    }
}
