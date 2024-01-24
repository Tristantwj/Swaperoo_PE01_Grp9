using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageContent { get; set; }
        public DateTime DateCreated { get; set; }
        public string? SenderId { get; set; }
        public virtual User? Sender { get; set; }
        public int ChatId { get; set; }
        public virtual Chat? Chat { get; set; }
    }
}
