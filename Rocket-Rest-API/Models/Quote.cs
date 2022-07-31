using System;
using System.Collections.Generic;

namespace RocketElevators.Models
{
    public partial class Quote
    {
        public int Id { get; set; }
        public string TypeBuilding { get; set; } = null!;
        public int? NumApartment { get; set; }
        public int? NumFloor { get; set; }
        public int? NumElevator { get; set; }
        public int? NumOccupant { get; set; }
        public string? CompanyName { get; set; }
        public string? Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
