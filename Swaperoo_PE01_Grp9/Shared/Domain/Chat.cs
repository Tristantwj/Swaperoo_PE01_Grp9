using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Chat
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Chat name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Chat Created Date is required")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
        public int? PurchaseId { get; set; }
        public virtual Purchase? Purchase { get; set;}
        public int? SwapId { get; set; }
        public virtual Swap? Swap { get; set; }
        
    }
}
