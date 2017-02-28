namespace Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserHistories",
                c => new
                    {
                        UserHistoryId = c.Guid(nullable: false),
                        Name = c.String(),
                        Phone = c.String(),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AccountNumber = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        ModificationDate = c.DateTime(nullable: false),
                        ValidTillDate = c.DateTime(nullable: false),
                        IncomeDate = c.DateTime(nullable: false),
                        Notes = c.String(),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.UserHistoryId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        Name = c.String(),
                        Phone = c.String(),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AccountNumber = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        ModificationDate = c.DateTime(nullable: false),
                        ValidTillDate = c.DateTime(nullable: false),
                        IncomeDate = c.DateTime(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserHistories", "UserId", "dbo.Users");
            DropIndex("dbo.UserHistories", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.UserHistories");
        }
    }
}
