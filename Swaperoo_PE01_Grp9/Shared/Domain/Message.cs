using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Message
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Message Content is required")]
        [Display(Name = "Message Content")]
        public string MessageContent { get; set; }
        [Required(ErrorMessage = "Message Created Date is required")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
        [Required(ErrorMessage = "Sender ID is required")]
        [Display(Name = "Sender ID")]
        public int? SenderId { get; set; }
        public virtual User? Sender { get; set; }
        [Required(ErrorMessage = "Chat ID is required")]
        [Display(Name = "Chat ID")]
        public int ChatId { get; set; }
        public virtual Chat? Chat { get; set; }
    }
}
