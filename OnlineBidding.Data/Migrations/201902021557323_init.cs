namespace OnlineBidding.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auctions",
                c => new
                    {
                        ActionId = c.String(nullable: false, maxLength: 128),
                        Title = c.String(),
                        PictureUrl = c.String(),
                        Description = c.String(),
                        ActualAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartingTime = c.DateTime(nullable: false),
                        EndingTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ActionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Auctions");
        }
    }
}
