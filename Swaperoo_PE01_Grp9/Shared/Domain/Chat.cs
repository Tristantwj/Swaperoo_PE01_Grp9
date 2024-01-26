using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Chat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public int? PurchaseId { get; set; }
        public virtual Purchase? Purchase { get; set;}
        public int? SwapId { get; set; }
        public virtual Swap? Swap { get; set; }
        
    }
}
