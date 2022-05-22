using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; }
        public int? OfferId { get; set; }
        public Offer Offer { get; set; }

        public List<ReservationService> ReservationServices { get; set; }
        public List<RoomReservation> RoomReservations { get; set; }

    }
}
