using System;
using System.Collections.Generic;

namespace RocketElevators.Models
{
    public partial class Battery
    {
        public Battery()
        {
            Columns = new HashSet<Column>();
            Interventions = new HashSet<Intervention>();
        }

        public long Id { get; set; }
        public string Types { get; set; } = null!;
        public string Status { get; set; } = null!;
        public int EmployeeId { get; set; }
        public DateTime DateCommissioning { get; set; }
        public DateTime DateLastInspection { get; set; }
        public string CertificateOfOperations { get; set; } = null!;
        public string Information { get; set; } = null!;
        public string Notes { get; set; } = null!;
        public long? BuildingId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Building? Building { get; set; }
        public virtual ICollection<Column> Columns { get; set; }
        public virtual ICollection<Intervention> Interventions { get; set; }
    }
}
