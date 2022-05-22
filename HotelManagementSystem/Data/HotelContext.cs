using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.Data
{
    public class HotelContext : DbContext
    {
        public HotelContext():base("name=HotelManagementDB")
        {

        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FeatureRoom> FeaturesRoom { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Prices> Prices { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationService> ReservationServices { get; set; }
        public DbSet<RoomReservation> RoomReservations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }
        
    }
}
