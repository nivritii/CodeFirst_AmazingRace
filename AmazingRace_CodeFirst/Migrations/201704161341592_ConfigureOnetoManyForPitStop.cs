namespace AmazingRace_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfigureOnetoManyForPitStop : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Staff",
                c => new
                    {
                        StaffID = c.Int(nullable: false, identity: true),
                        StaffCode = c.String(),
                        StaffName = c.String(),
                        TeamStaff = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StaffID);
            
            AddColumn("dbo.Team", "Staff_StaffID", c => c.Int());
            CreateIndex("dbo.PitStop", "StaffID");
            CreateIndex("dbo.Team", "Staff_StaffID");
            AddForeignKey("dbo.PitStop", "StaffID", "dbo.Staff", "StaffID", cascadeDelete: true);
            AddForeignKey("dbo.Team", "Staff_StaffID", "dbo.Staff", "StaffID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Team", "Staff_StaffID", "dbo.Staff");
            DropForeignKey("dbo.PitStop", "StaffID", "dbo.Staff");
            DropIndex("dbo.Team", new[] { "Staff_StaffID" });
            DropIndex("dbo.PitStop", new[] { "StaffID" });
            DropColumn("dbo.Team", "Staff_StaffID");
            DropTable("dbo.Staff");
        }
    }
}
