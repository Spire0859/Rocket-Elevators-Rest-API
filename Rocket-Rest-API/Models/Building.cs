using System;
using System.Collections.Generic;

namespace RocketElevators.Models
{
    public partial class Building
    {
        public Building()
        {
            Batteries = new HashSet<Battery>();
            BuildingDetails = new HashSet<BuildingDetail>();
            Interventions = new HashSet<Intervention>();
        }

        public long Id { get; set; }
        public string? AddressOfBuilding { get; set; }
        public string FullNameBuildingAdmin { get; set; } = null!;
        public string EmailBuildingAdmin { get; set; } = null!;
        public string PhoneBuildingAdmin { get; set; } = null!;
        public string FullNameTechnicalAuthority { get; set; } = null!;
        public string EmailTechnicalAuthority { get; set; } = null!;
        public string PhoneTechnicalAuthority { get; set; } = null!;
        public string? InterventionDateStart { get; set; }
        public string? InterventionDateEnd { get; set; }
        public long? CustomerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Battery> Batteries { get; set; }
        public virtual ICollection<BuildingDetail> BuildingDetails { get; set; }
        public virtual ICollection<Intervention> Interventions { get; set; }
    }
}
