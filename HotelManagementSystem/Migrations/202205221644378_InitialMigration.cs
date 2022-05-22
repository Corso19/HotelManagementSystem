namespace HotelManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FeatureRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeatureId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Features", t => t.FeatureId, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.FeatureId)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Floor = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.Binary(),
                        RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Offers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        RoomId = c.Int(nullable: false),
                        Period = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        OfferId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Offers", t => t.OfferId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.OfferId);
            
            CreateTable(
                "dbo.ReservationServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReservationId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservations", t => t.ReservationId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.ReservationId)
                .Index(t => t.ServiceId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoomReservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomId = c.Int(nullable: false),
                        ReservationId = c.Int(nullable: false),
                        NoRooms = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservations", t => t.ReservationId, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId)
                .Index(t => t.ReservationId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Value = c.Single(nullable: false),
                        RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prices", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Offers", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Reservations", "UserId", "dbo.Users");
            DropForeignKey("dbo.RoomReservations", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.RoomReservations", "ReservationId", "dbo.Reservations");
            DropForeignKey("dbo.ReservationServices", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.ReservationServices", "ReservationId", "dbo.Reservations");
            DropForeignKey("dbo.Reservations", "OfferId", "dbo.Offers");
            DropForeignKey("dbo.Images", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.FeatureRooms", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.FeatureRooms", "FeatureId", "dbo.Features");
            DropIndex("dbo.Prices", new[] { "RoomId" });
            DropIndex("dbo.RoomReservations", new[] { "ReservationId" });
            DropIndex("dbo.RoomReservations", new[] { "RoomId" });
            DropIndex("dbo.ReservationServices", new[] { "ServiceId" });
            DropIndex("dbo.ReservationServices", new[] { "ReservationId" });
            DropIndex("dbo.Reservations", new[] { "OfferId" });
            DropIndex("dbo.Reservations", new[] { "UserId" });
            DropIndex("dbo.Offers", new[] { "RoomId" });
            DropIndex("dbo.Images", new[] { "RoomId" });
            DropIndex("dbo.FeatureRooms", new[] { "RoomId" });
            DropIndex("dbo.FeatureRooms", new[] { "FeatureId" });
            DropTable("dbo.Prices");
            DropTable("dbo.Users");
            DropTable("dbo.RoomReservations");
            DropTable("dbo.Services");
            DropTable("dbo.ReservationServices");
            DropTable("dbo.Reservations");
            DropTable("dbo.Offers");
            DropTable("dbo.Images");
            DropTable("dbo.Rooms");
            DropTable("dbo.FeatureRooms");
            DropTable("dbo.Features");
        }
    }
}
