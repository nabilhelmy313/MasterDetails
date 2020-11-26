namespace CustomerService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigrate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cities", "City_Id", "dbo.Cities");
            DropIndex("dbo.Cities", new[] { "City_Id" });
            DropColumn("dbo.Cities", "City_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cities", "City_Id", c => c.Int());
            CreateIndex("dbo.Cities", "City_Id");
            AddForeignKey("dbo.Cities", "City_Id", "dbo.Cities", "Id");
        }
    }
}
