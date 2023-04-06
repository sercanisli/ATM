namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatetimeProcess : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AccountInformations", "CreatedDate", c => c.String());
            AlterColumn("dbo.Customers", "CreatedDate", c => c.String());
            AlterColumn("dbo.Bills", "CreatedDate", c => c.String());
            AlterColumn("dbo.BillTypes", "CreatedDate", c => c.String());
            AlterColumn("dbo.NonCustomers", "CreatedDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NonCustomers", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BillTypes", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Bills", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AccountInformations", "CreatedDate", c => c.DateTime(nullable: false));
        }
    }
}
