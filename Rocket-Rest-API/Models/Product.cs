using System;
using System.Collections.Generic;

namespace RocketElevators.Models
{
    public partial class Product
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
