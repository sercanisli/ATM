namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializCreditCardEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        CardNo = c.Int(nullable: false),
                        Debt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Limit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CreditCards", "CustomerId", "dbo.Customers");
            DropIndex("dbo.CreditCards", new[] { "CustomerId" });
            DropTable("dbo.CreditCards");
        }
    }
}
