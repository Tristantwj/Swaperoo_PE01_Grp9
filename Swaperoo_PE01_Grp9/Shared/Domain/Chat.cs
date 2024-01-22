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
        public string? ChatProfilePicture { get; set; }
        public DateTime DateCreated { get; set; }
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        
    }
}
