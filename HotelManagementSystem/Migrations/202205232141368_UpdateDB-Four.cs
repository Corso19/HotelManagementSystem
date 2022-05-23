namespace HotelManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDBFour : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Offers", "StartDate", c => c.DateTime());
            AlterColumn("dbo.Offers", "EndDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Offers", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Offers", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
