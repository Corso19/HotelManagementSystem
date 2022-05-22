using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class RoomReservation
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }
        public int NoRooms { get; set; }

    }
}
