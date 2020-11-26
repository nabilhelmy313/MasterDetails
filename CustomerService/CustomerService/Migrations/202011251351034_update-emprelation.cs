namespace CustomerService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateemprelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departments", "Branch_Id", "dbo.Branches");
            DropIndex("dbo.Departments", new[] { "Branch_Id" });
            AddColumn("dbo.Employees", "Branch_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Branch_Id");
            AddForeignKey("dbo.Employees", "Branch_Id", "dbo.Branches", "Id");
            DropColumn("dbo.Departments", "Branch_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "Branch_Id", c => c.Int());
            DropForeignKey("dbo.Employees", "Branch_Id", "dbo.Branches");
            DropIndex("dbo.Employees", new[] { "Branch_Id" });
            DropColumn("dbo.Employees", "Branch_Id");
            CreateIndex("dbo.Departments", "Branch_Id");
            AddForeignKey("dbo.Departments", "Branch_Id", "dbo.Branches", "Id");
        }
    }
}
