namespace CustomerService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddepartment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Branch_Id", "dbo.Branches");
            DropIndex("dbo.Employees", new[] { "Branch_Id" });
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Branch_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.Branch_Id)
                .Index(t => t.Branch_Id);
            
            AddColumn("dbo.Employees", "Department_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Department_Id");
            AddForeignKey("dbo.Employees", "Department_Id", "dbo.Departments", "Id");
            DropColumn("dbo.Employees", "Branch_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Branch_Id", c => c.Int());
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Departments", "Branch_Id", "dbo.Branches");
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            DropIndex("dbo.Departments", new[] { "Branch_Id" });
            DropColumn("dbo.Employees", "Department_Id");
            DropTable("dbo.Departments");
            CreateIndex("dbo.Employees", "Branch_Id");
            AddForeignKey("dbo.Employees", "Branch_Id", "dbo.Branches", "Id");
        }
    }
}
