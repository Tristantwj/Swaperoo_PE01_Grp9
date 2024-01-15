using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Swap
    {
        public int SwapId { get; set; }
        public DateTime SwapDate { get; set; }
        public int OfferItemID { get; set; }
        public virtual Product? OfferItem { get; set; }
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public int BuyerId { get; set; }
        public virtual User? Buyer { get; set; }
        public int SellertId { get; set; }
        public virtual User? Seller { get; set; }
    }
}
