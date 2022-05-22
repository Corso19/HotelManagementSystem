﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int Floor { get; set; }
        public int Number { get; set; }
        public bool Active { get; set; }
        public int RoomTypeId { get; set; }

        public RoomType Type { get; set; }
        public List<Prices> Prices { get; set; }

    }
}
