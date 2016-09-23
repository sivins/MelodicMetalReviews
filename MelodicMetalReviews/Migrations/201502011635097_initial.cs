namespace MelodicMetalReviews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumID = c.Int(nullable: false, identity: true),
                        AlbumName = c.String(nullable: false, maxLength: 100),
                        ImagePath = c.String(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        Review = c.String(nullable: false),
                        Rating = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BandID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AlbumID)
                .ForeignKey("dbo.Bands", t => t.BandID, cascadeDelete: true)
                .Index(t => t.BandID);
            
            CreateTable(
                "dbo.Bands",
                c => new
                    {
                        BandID = c.Int(nullable: false, identity: true),
                        BandName = c.String(nullable: false, maxLength: 100),
                        Bio = c.String(nullable: false),
                        ImagePath = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.BandID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Albums", "BandID", "dbo.Bands");
            DropIndex("dbo.Albums", new[] { "BandID" });
            DropTable("dbo.Bands");
            DropTable("dbo.Albums");
        }
    }
}
