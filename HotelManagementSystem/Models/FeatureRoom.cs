using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class FeatureRoom
    {
        public int Id { get; set; }
        public int FeatureId { get; set; }
        public Feature Feature { get; set; } 
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
