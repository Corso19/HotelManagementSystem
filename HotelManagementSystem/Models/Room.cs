using System;
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

        public bool Deleted { get; set; }

        public List<Prices> Prices { get; set; }
        public List<Image> Images { get; set; }
        public List<FeatureRoom> FeaturesRoom { get; set; }
        public List<RoomReservation> RoomReservations { get; set; }
        public List<Offer> Offers { get; set; }

    }
}
