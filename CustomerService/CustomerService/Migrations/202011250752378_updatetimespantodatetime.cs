namespace CustomerService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetimespantodatetime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Branches", "StartTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Branches", "EndTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Branches", "EndTime", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Branches", "StartTime", c => c.Time(nullable: false, precision: 7));
        }
    }
}
