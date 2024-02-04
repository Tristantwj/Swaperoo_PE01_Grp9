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
        public string? BuyerStatus { get; set; }
        public string? SellerStatus { get; set; }
        public int OfferItemId { get; set; }
        public virtual Product? OfferItem { get; set; }
        public int? SwapProductId { get; set; }
        public virtual Product? SwapProduct { get; set; }
    }
}
