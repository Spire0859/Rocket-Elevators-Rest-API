using System;
using System.Collections.Generic;

namespace RocketElevators.Models
{
    public partial class Intervention
    {
        public long Id { get; set; }
        public string InterventionDateStart { get; set; } = null!;
        public string? InterventionDateEnd { get; set; }
        public string? Result { get; set; }
        public string? Report { get; set; }
        public string? Status { get; set; }
        public long? EmployeeId { get; set; }
        public long? BuildingId { get; set; }
        public long? BatteryId { get; set; }
        public long? ColumnId { get; set; }
        public long? ElevatorId { get; set; }

        public virtual Battery? Battery { get; set; }
        public virtual Building? Building { get; set; }
        public virtual Column? Column { get; set; }
        public virtual Elevator? Elevator { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
