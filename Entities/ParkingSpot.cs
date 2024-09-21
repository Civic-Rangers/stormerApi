using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ParkingSpot
    {
        public Guid? Id { get; set; }
        public string? Address { get; set; }
        public bool? IsFilled { get; set; } = false; // Whether the parking spot is filled

        public Guid? UserId { get; set; } // The owner of the parking spot
        public User? User { get; set; } // Navigation property
    }
}
