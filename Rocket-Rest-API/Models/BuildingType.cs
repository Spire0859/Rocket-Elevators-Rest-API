using System;
using System.Collections.Generic;

namespace RocketElevators.Models
{
    public partial class BuildingType
    {
        public long Id { get; set; }
        public int? NumberApartments { get; set; }
        public int? NumberFloors { get; set; }
        public int? NumberElevators { get; set; }
        public int? NumberOccupants { get; set; }
        public string? CompanyName { get; set; }
        public string? Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
