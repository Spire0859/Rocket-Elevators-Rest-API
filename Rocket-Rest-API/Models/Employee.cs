using System;
using System.Collections.Generic;

namespace RocketElevators.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Interventions = new HashSet<Intervention>();
        }

        public long Id { get; set; }
        public string FirstNname { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public long? UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<Intervention> Interventions { get; set; }
    }
}
