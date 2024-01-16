using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ItemDescription { get; set; }
        public string? imagepath { get; set; }
        public double price { get; set; }
        public string status { get; set; }
        public int UserID { get; set; }
        public virtual User? User { get; set; }
        public int SubCategoryId { get; set; }
        public virtual SubCategory? SubCategory { get; set; }
    }

}
