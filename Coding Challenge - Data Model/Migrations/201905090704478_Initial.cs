namespace CodingChallenge.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Credits = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserProjects",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        ProjectId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        AssignedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.ProjectId })
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserProjects", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserProjects", "ProjectId", "dbo.Projects");
            DropIndex("dbo.UserProjects", new[] { "ProjectId" });
            DropIndex("dbo.UserProjects", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.UserProjects");
            DropTable("dbo.Projects");
        }
    }
}
