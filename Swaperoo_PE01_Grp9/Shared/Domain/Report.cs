using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Report
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Report Type is required")]
        [Display(Name = "Report Type")]
        public string ReportType { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Description ID")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Report Date created is required")]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
        [Required(ErrorMessage = "Status is required")]
        [Display(Name = "Status")]
        public string status { get; set; }
        [Required(ErrorMessage = "Reporter is required")]
        [Display(Name = "Reporter ID")]
        public int? ReporterUserId { get; set; }
        public virtual User? ReporterUser { get; set; }
        public int? ReportedUserId { get; set; }
        public virtual User? ReportedUser { get; set; }
        public int? ReportedProductId { get; set; }
        public virtual Product? ReportedProduct { get; set; }
    }
}
