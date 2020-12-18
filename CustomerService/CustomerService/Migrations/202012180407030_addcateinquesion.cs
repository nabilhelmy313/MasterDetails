namespace CustomerService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcateinquesion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "Category_Id", c => c.Int());
            CreateIndex("dbo.Questions", "Category_Id");
            AddForeignKey("dbo.Questions", "Category_Id", "dbo.Categories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Questions", new[] { "Category_Id" });
            DropColumn("dbo.Questions", "Category_Id");
        }
    }
}
