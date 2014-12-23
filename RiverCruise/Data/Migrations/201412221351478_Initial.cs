namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ref = c.String(),
                        Date = c.DateTime(nullable: false),
                        Remarks = c.String(),
                        Flag = c.String(),
                        Eni = c.String(),
                        Port = c.String(),
                        CrewNationalities = c.String(),
                        Agent_Id = c.Int(),
                        Company_Id = c.Int(),
                        Contract_Id = c.Int(),
                        Ship_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Agents", t => t.Agent_Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .ForeignKey("dbo.Contracts", t => t.Contract_Id)
                .ForeignKey("dbo.Ships", t => t.Ship_Id)
                .Index(t => t.Agent_Id)
                .Index(t => t.Company_Id)
                .Index(t => t.Contract_Id)
                .Index(t => t.Ship_Id);
            
            CreateTable(
                "dbo.Agents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nautic = c.String(),
                        Horeca = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nautic = c.String(),
                        Crew = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Eni = c.String(),
                        Flag = c.String(),
                        NauticalCrew = c.Int(nullable: false),
                        HotelStaff = c.Int(nullable: false),
                        Company_Id = c.Int(),
                        Region_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .ForeignKey("dbo.Regions", t => t.Region_Id)
                .Index(t => t.Company_Id)
                .Index(t => t.Region_Id);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reports", "Ship_Id", "dbo.Ships");
            DropForeignKey("dbo.Ships", "Region_Id", "dbo.Regions");
            DropForeignKey("dbo.Ships", "Company_Id", "dbo.Companies");
            DropForeignKey("dbo.Reports", "Contract_Id", "dbo.Contracts");
            DropForeignKey("dbo.Reports", "Company_Id", "dbo.Companies");
            DropForeignKey("dbo.Reports", "Agent_Id", "dbo.Agents");
            DropIndex("dbo.Ships", new[] { "Region_Id" });
            DropIndex("dbo.Ships", new[] { "Company_Id" });
            DropIndex("dbo.Reports", new[] { "Ship_Id" });
            DropIndex("dbo.Reports", new[] { "Contract_Id" });
            DropIndex("dbo.Reports", new[] { "Company_Id" });
            DropIndex("dbo.Reports", new[] { "Agent_Id" });
            DropTable("dbo.Regions");
            DropTable("dbo.Ships");
            DropTable("dbo.Contracts");
            DropTable("dbo.Agents");
            DropTable("dbo.Reports");
            DropTable("dbo.Companies");
        }
    }
}
