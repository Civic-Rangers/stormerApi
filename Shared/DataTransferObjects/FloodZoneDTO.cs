﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class FloodZoneDTO
    {
        public Guid? Id { get; set; }
        public string? Address { get; set; }
        public Guid? UserId { get; set; }
    }
}
