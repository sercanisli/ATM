namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialize2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "AccountInformationId", "dbo.AccountInformations");
            DropIndex("dbo.Customers", new[] { "AccountInformationId" });
            AddColumn("dbo.AccountInformations", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.AccountInformations", "CustomerId");
            AddForeignKey("dbo.AccountInformations", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            DropColumn("dbo.Customers", "AccountInformationId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "AccountInformationId", c => c.Int(nullable: false));
            DropForeignKey("dbo.AccountInformations", "CustomerId", "dbo.Customers");
            DropIndex("dbo.AccountInformations", new[] { "CustomerId" });
            DropColumn("dbo.AccountInformations", "CustomerId");
            CreateIndex("dbo.Customers", "AccountInformationId");
            AddForeignKey("dbo.Customers", "AccountInformationId", "dbo.AccountInformations", "Id", cascadeDelete: true);
        }
    }
}
