namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AccountInformations", "CustomerNo", "dbo.Customers");
            DropIndex("dbo.AccountInformations", new[] { "CustomerNo" });
            AddColumn("dbo.AccountInformations", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.AccountInformations", "CustomerId");
            AddForeignKey("dbo.AccountInformations", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountInformations", "CustomerId", "dbo.Customers");
            DropIndex("dbo.AccountInformations", new[] { "CustomerId" });
            DropColumn("dbo.AccountInformations", "CustomerId");
            CreateIndex("dbo.AccountInformations", "CustomerNo");
            AddForeignKey("dbo.AccountInformations", "CustomerNo", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
