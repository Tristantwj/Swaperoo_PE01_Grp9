using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Chat
    {
        public int ChatId { get; set; }
        public string ChatName { get; set; }
        public string? ChatProfilePicture { get; set; }
        public DateTime ChatCreatedDate { get; set; }
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
