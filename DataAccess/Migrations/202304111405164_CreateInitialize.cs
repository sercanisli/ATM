namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateInitialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Money = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CustomerId = c.Int(nullable: false),
                        CustomerNo = c.Int(nullable: false),
                        CreatedDate = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        CustomerNo = c.Int(nullable: false),
                        BirthDay = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        PhoneNo = c.String(),
                        CreatedDate = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CardLimits",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Limit = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        CardNo = c.Int(nullable: false),
                        Debt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CardLimitId = c.Byte(nullable: false),
                        CreatedDate = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CardLimits", t => t.CardLimitId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.CardLimitId);
            
            CreateTable(
                "dbo.NonCustomers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        PhoneNo = c.String(),
                        IdentityNo = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PayBills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        BillId = c.Byte(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bills", t => t.BillId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.BillId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PayBills", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.PayBills", "BillId", "dbo.Bills");
            DropForeignKey("dbo.CreditCards", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.CreditCards", "CardLimitId", "dbo.CardLimits");
            DropForeignKey("dbo.AccountInformations", "CustomerId", "dbo.Customers");
            DropIndex("dbo.PayBills", new[] { "BillId" });
            DropIndex("dbo.PayBills", new[] { "CustomerId" });
            DropIndex("dbo.CreditCards", new[] { "CardLimitId" });
            DropIndex("dbo.CreditCards", new[] { "CustomerId" });
            DropIndex("dbo.AccountInformations", new[] { "CustomerId" });
            DropTable("dbo.PayBills");
            DropTable("dbo.NonCustomers");
            DropTable("dbo.CreditCards");
            DropTable("dbo.CardLimits");
            DropTable("dbo.Bills");
            DropTable("dbo.Customers");
            DropTable("dbo.AccountInformations");
        }
    }
}
