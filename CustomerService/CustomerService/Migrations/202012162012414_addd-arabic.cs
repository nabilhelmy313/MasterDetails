namespace CustomerService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddarabic : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Answers", "TextAr", c => c.String());
            AddColumn("dbo.Questions", "TextAr", c => c.String());
            AddColumn("dbo.Categories", "NameAr", c => c.String());
            AddColumn("dbo.Branches", "NameAr", c => c.String());
            AddColumn("dbo.Cities", "NameAr", c => c.String());
            AddColumn("dbo.Countries", "NameAr", c => c.String());
            AddColumn("dbo.Employees", "NameAr", c => c.String());
            AddColumn("dbo.Departments", "NameAr", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "NameAr");
            DropColumn("dbo.Employees", "NameAr");
            DropColumn("dbo.Countries", "NameAr");
            DropColumn("dbo.Cities", "NameAr");
            DropColumn("dbo.Branches", "NameAr");
            DropColumn("dbo.Categories", "NameAr");
            DropColumn("dbo.Questions", "TextAr");
            DropColumn("dbo.Answers", "TextAr");
        }
    }
}
