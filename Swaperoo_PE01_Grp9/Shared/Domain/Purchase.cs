using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime SellDate { get; set; }
        public double OfferPrice { get; set; }
        public int? UserId { get; set; }
        public virtual User? User { get; set; }
        public int? ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
