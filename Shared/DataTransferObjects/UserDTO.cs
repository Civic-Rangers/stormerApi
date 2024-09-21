﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class UserDTO
    {
        [Column("UserId")]
        public Guid? Id { get; set; }

        [Column("Name")]
        public string? Name { get; set; }

        [Column("Password")]
        public string? Password { get; set; }

        [Column("ParkingSpot")]
        public List<ParkingSpotDTO>? ParkingSpots { get; set; }
    }
}
