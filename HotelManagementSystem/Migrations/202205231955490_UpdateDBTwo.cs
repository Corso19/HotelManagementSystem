namespace HotelManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDBTwo : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Offers", "Period");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Offers", "Period", c => c.Int(nullable: false));
        }
    }
}
