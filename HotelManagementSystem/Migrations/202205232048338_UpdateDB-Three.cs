namespace HotelManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDBThree : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Offers", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Offers", "Price");
        }
    }
}
