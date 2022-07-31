using System;
using System.Collections.Generic;

namespace RocketElevators.Models
{
    public partial class GoogleMapsCustomersLocation
    {
        public long Id { get; set; }
        public string? LocationBuilding { get; set; }
        public int? BuildingFloors { get; set; }
        public string? ClientName { get; set; }
        public int? NbBattries { get; set; }
        public int? NbColumns { get; set; }
        public int? NbElevators { get; set; }
        public string? TechContact { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
