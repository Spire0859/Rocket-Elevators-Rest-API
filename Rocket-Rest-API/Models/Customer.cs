using System;
using System.Collections.Generic;

namespace RocketElevators.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Leads = new HashSet<Lead>();
        }

        public long Id { get; set; }
        public DateTime? DateCreation { get; set; }
        public string CompanyName { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? CompanyHqAddresse { get; set; }
        public string? FullNameTechnicalAuthority { get; set; }
        public string? TechnicalAuthorityPhone { get; set; }
        public string? TechnicalAuthorityEmail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? UserId { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<Lead> Leads { get; set; }
    }
}
