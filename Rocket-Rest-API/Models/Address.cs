using System;
using System.Collections.Generic;

namespace RocketElevators.Models
{
    public partial class Address
    {
        public long Id { get; set; }
        public string AddressType { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string Entity { get; set; } = null!;
        public string NumberAndStreet { get; set; } = null!;
        public string SuiteOrApartment { get; set; } = null!;
        public string City { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Notes { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? CustomerId { get; set; }
        public long? BuildingId { get; set; }
    }
}
