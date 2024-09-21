using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FloodZone
    {
        [Column("Id")]
        public Guid? Id { get; set; }

        [Column("Address")]
        public string? Address { get; set; }

        [Column("UserId")]
        public Guid? UserId { get; set; } // The user that made the flood zone post

        [Column("User")]
        public User? User { get; set; } // Navigation propertyCo
    }
}
