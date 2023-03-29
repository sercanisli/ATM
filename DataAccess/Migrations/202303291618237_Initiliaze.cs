﻿namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initiliaze : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Money = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        BillId = c.Byte(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BillTypes", t => t.BillId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.BillId);
            
            CreateTable(
                "dbo.BillTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        CustomerNo = c.String(),
                        BirthDay = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                        AccountInformationId = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        PhoneNo = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountInformations", t => t.AccountInformationId, cascadeDelete: true)
                .Index(t => t.AccountInformationId);
            
            CreateTable(
                "dbo.NonCustomers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        PhoneNo = c.String(),
                        IdentityNo = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bills", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Customers", "AccountInformationId", "dbo.AccountInformations");
            DropForeignKey("dbo.Bills", "BillId", "dbo.BillTypes");
            DropIndex("dbo.Customers", new[] { "AccountInformationId" });
            DropIndex("dbo.Bills", new[] { "BillId" });
            DropIndex("dbo.Bills", new[] { "CustomerId" });
            DropTable("dbo.NonCustomers");
            DropTable("dbo.Customers");
            DropTable("dbo.BillTypes");
            DropTable("dbo.Bills");
            DropTable("dbo.AccountInformations");
        }
    }
}
