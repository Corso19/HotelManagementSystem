namespace HotelManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Features", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rooms", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Offers", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Services", "Deleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Deleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Deleted");
            DropColumn("dbo.Services", "Deleted");
            DropColumn("dbo.Offers", "Deleted");
            DropColumn("dbo.Rooms", "Deleted");
            DropColumn("dbo.Features", "Deleted");
        }
    }
}
