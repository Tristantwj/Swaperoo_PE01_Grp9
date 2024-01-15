using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Messages
    {
        public int MessageId { get; set; }
        public string MessageContent { get; set; }
        public DateTime SentTime { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public int ChatId { get; set; }
        public virtual Chat? Chat { get; set; }
    }
}
