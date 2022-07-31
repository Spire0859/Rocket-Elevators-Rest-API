using System;
using System.Collections.Generic;

namespace RocketElevators.Models
{
    public partial class Column
    {
        public Column()
        {
            Elevators = new HashSet<Elevator>();
            Interventions = new HashSet<Intervention>();
        }

        public long Id { get; set; }
        public string Types { get; set; } = null!;
        public string? Model { get; set; }
        public string NumberFloorServed { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string Information { get; set; } = null!;
        public string Notes { get; set; } = null!;
        public long? BatteryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Battery? Battery { get; set; }
        public virtual ICollection<Elevator> Elevators { get; set; }
        public virtual ICollection<Intervention> Interventions { get; set; }
    }
}
