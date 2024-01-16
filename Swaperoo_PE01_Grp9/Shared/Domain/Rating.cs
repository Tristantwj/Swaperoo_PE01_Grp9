using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Rating
    {
        public int Id { get; set; }
        public int RatingValue { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public int? PurchaseId { get; set; }
        public virtual Purchase? Purchase { get; set; }
        public int? SwapId { get; set; }
        public virtual Swap? Swap { get; set;}
    }
}
