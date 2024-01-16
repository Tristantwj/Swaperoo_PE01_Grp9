using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
