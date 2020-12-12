namespace CustomerService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FAQclasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Photo = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        IsUpdated = c.Boolean(nullable: false),
                        Question_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.Question_Id)
                .Index(t => t.Question_Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        IsUpdated = c.Boolean(nullable: false),
                        Keyword_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Keywords", t => t.Keyword_Id)
                .Index(t => t.Keyword_Id);
            
            CreateTable(
                "dbo.Keywords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Word = c.String(),
                        Counter = c.Int(nullable: false),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "Keyword_Id", "dbo.Keywords");
            DropForeignKey("dbo.Keywords", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Answers", "Question_Id", "dbo.Questions");
            DropIndex("dbo.Keywords", new[] { "Category_Id" });
            DropIndex("dbo.Questions", new[] { "Keyword_Id" });
            DropIndex("dbo.Answers", new[] { "Question_Id" });
            DropTable("dbo.Categories");
            DropTable("dbo.Keywords");
            DropTable("dbo.Questions");
            DropTable("dbo.Answers");
        }
    }
}
