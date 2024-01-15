﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class Report
    {
        public int ReportId { get; set; }
        public string ReportType { get; set; }
        public string ReportDescription { get; set; }
        public DateTime ReportDate { get; set; }
        public string status { get; set; }
        public int? ReporterUserId { get; set; }
        public virtual User? Reporter {  get; set; }
        public int? ReportedUserId { get; set; }
        public virtual User? ReportedUser { get; set; }
        public int? ReportedProductId { get; set; }
        public virtual Product? ReportedProduct { get; set; }
    }
}
