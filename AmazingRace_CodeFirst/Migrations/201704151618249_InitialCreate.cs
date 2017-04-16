namespace AmazingRace_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Event",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                        Description = c.String(),
                        Country = c.String(),
                        City = c.String(),
                        EventStart = c.DateTime(nullable: false),
                        EventEnd = c.DateTime(nullable: false),
                        TotalPitStops = c.Int(nullable: false),
                        TotalTeams = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EventID);
            
            CreateTable(
                "dbo.Team",
                c => new
                    {
                        TeamID = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                        EventID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeamID)
                .ForeignKey("dbo.Event", t => t.EventID, cascadeDelete: true)
                .Index(t => t.EventID);
            
            CreateTable(
                "dbo.Member",
                c => new
                    {
                        MemberID = c.Int(nullable: false, identity: true),
                        MemberName = c.String(),
                        TeamID = c.Int(nullable: false),
                        ContactNo = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.MemberID)
                .ForeignKey("dbo.Team", t => t.TeamID, cascadeDelete: true)
                .Index(t => t.TeamID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Member", "TeamID", "dbo.Team");
            DropForeignKey("dbo.Team", "EventID", "dbo.Event");
            DropIndex("dbo.Member", new[] { "TeamID" });
            DropIndex("dbo.Team", new[] { "EventID" });
            DropTable("dbo.Member");
            DropTable("dbo.Team");
            DropTable("dbo.Event");
        }
    }
}
