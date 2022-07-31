using System;
using System.Collections.Generic;

namespace RocketElevators.Models
{
    public partial class Elevator
    {
        public Elevator()
        {
            Interventions = new HashSet<Intervention>();
        }

        public long Id { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Types { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime DateCommissioning { get; set; }
        public DateTime DateLastInspection { get; set; }
        public string CertificateOperations { get; set; } = null!;
        public string Information { get; set; } = null!;
        public string Notes { get; set; } = null!;
        public long? ColumnId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Column? Column { get; set; }
        public virtual ICollection<Intervention> Interventions { get; set; }
    }
}
