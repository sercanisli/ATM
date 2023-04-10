namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeCardLimit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CardLimits",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Limit = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.CreditCards", "CardLimitId", c => c.Byte(nullable: false));
            CreateIndex("dbo.CreditCards", "CardLimitId");
            AddForeignKey("dbo.CreditCards", "CardLimitId", "dbo.CardLimits", "Id", cascadeDelete: true);
            DropColumn("dbo.CreditCards", "Limit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CreditCards", "Limit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropForeignKey("dbo.CreditCards", "CardLimitId", "dbo.CardLimits");
            DropIndex("dbo.CreditCards", new[] { "CardLimitId" });
            DropColumn("dbo.CreditCards", "CardLimitId");
            DropTable("dbo.CardLimits");
        }
    }
}
