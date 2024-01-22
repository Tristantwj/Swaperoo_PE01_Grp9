﻿using System.ComponentModel.DataAnnotations;

namespace Swaperoo_PE01_Grp9.Shared.Domain
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Email { get; set; }
        public string? Description { get; set; }
        public virtual List<Product>? Products { get; set; }
    }
}
