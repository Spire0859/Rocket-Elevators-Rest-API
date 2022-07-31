using System;
using System.Collections.Generic;

namespace RocketElevators.Models
{
    public partial class Lead
    {
        public long Id { get; set; }
        public string? FullNameContact { get; set; }
        public string? CompanyName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? NameProject { get; set; }
        public string? DescriptionProject { get; set; }
        public string? Department { get; set; }
        public string? Message { get; set; }
        public byte[]? File { get; set; }
        public DateTime? Date { get; set; }
        public long? CustomerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
