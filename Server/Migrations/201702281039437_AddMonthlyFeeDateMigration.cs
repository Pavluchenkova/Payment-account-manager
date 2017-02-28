namespace Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMonthlyFeeDateMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserHistories", "MonthlyFeeDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "MonthlyFeeDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "MonthlyFeeDate");
            DropColumn("dbo.UserHistories", "MonthlyFeeDate");
        }
    }
}
