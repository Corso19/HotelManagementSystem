﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class Prices
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Value  { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }

    }
}
