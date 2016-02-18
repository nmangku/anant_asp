namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LocationTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationID = c.Int(nullable: false, identity: true),
                        LocationName = c.String(),
                        LocationDescription = c.String(),
                        LocationAddress = c.String(),
                        LocationLatitude = c.Int(nullable: false),
                        LocationLongitude = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LocationID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Locations");
        }
    }
}
