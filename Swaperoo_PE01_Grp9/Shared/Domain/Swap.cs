using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Swap
    {
        public int Id { get; set; }
        public DateTime SwapDate { get; set; }
        public string? Status { get; set; }
        public int OfferItemId { get; set; }
        public virtual Product? OfferItem { get; set; }
        public int? SwapProductId { get; set; }
        public virtual Product? SwapProduct { get; set; }
        public int? BuyerId { get; set; }
        public virtual User? Buyer { get; set; }
        public int? SellerId { get; set; }
        public virtual User? Seller { get; set; }
    }
}
