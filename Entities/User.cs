using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public ICollection<ParkingSpot>? ParkingSpots { get; set; } = new List<ParkingSpot>();
    }
}
