namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class myMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        adminID = c.Int(nullable: false, identity: true),
                        adminStatu = c.Boolean(),
                        customerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.adminID)
                .ForeignKey("dbo.Customers", t => t.customerID, cascadeDelete: true)
                .Index(t => t.customerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        customerID = c.Int(nullable: false, identity: true),
                        username = c.String(maxLength: 100),
                        password = c.String(maxLength: 100),
                        customerFirstName = c.String(maxLength: 100),
                        customerLastName = c.String(maxLength: 100),
                        customerMail = c.String(maxLength: 200),
                        customerPhone = c.String(maxLength: 20),
                        customerBirthDate = c.DateTime(),
                        customerCreatedDate = c.DateTime(),
                        customerImageUrl = c.String(),
                        customerStatu = c.Boolean(),
                    })
                .PrimaryKey(t => t.customerID);
            
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        adressID = c.Int(nullable: false, identity: true),
                        adressName = c.String(maxLength: 50),
                        adressLine = c.String(maxLength: 100),
                        adressStatu = c.Boolean(),
                        customerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.adressID)
                .ForeignKey("dbo.Customers", t => t.customerID, cascadeDelete: true)
                .Index(t => t.customerID);
            
            CreateTable(
                "dbo.BankCards",
                c => new
                    {
                        bankCardID = c.Int(nullable: false, identity: true),
                        bankCardName = c.String(maxLength: 50),
                        bankCardNo = c.String(maxLength: 50),
                        bankCardType = c.String(maxLength: 50),
                        bankCardExpiryDate = c.String(maxLength: 5),
                        bankCardStatu = c.Boolean(),
                        customerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.bankCardID)
                .ForeignKey("dbo.Customers", t => t.customerID, cascadeDelete: true)
                .Index(t => t.customerID);
            
            CreateTable(
                "dbo.PreOrders",
                c => new
                    {
                        preOrderID = c.Int(nullable: false, identity: true),
                        preOrderDate = c.DateTime(),
                        preOrderDeliveryDate = c.DateTime(),
                        preOrderQuantity = c.Int(),
                        preOrderStatu = c.Byte(),
                        preOrderNote = c.String(maxLength: 200),
                        cartStatu = c.Boolean(),
                        customerID = c.Int(nullable: false),
                        productID = c.Int(nullable: false),
                        paymentMethodID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.preOrderID)
                .ForeignKey("dbo.Customers", t => t.customerID, cascadeDelete: true)
                .ForeignKey("dbo.PaymentMethods", t => t.paymentMethodID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.productID, cascadeDelete: true)
                .Index(t => t.customerID)
                .Index(t => t.productID)
                .Index(t => t.paymentMethodID);
            
            CreateTable(
                "dbo.PaymentMethods",
                c => new
                    {
                        paymentMethodID = c.Int(nullable: false, identity: true),
                        paymentMethodName = c.String(maxLength: 50),
                        paymentMethodStatu = c.Boolean(),
                    })
                .PrimaryKey(t => t.paymentMethodID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productID = c.Int(nullable: false, identity: true),
                        productName = c.String(maxLength: 100),
                        productImageUrl = c.String(),
                        productUnitInStock = c.Short(),
                        productUnitPrice = c.Decimal(precision: 18, scale: 2),
                        productDescription = c.String(maxLength: 200),
                        productColor = c.String(maxLength: 100),
                        productStatu = c.Boolean(),
                        categoryID = c.Int(nullable: false),
                        discountID = c.Int(nullable: false),
                        collectionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.productID)
                .ForeignKey("dbo.Categories", t => t.categoryID, cascadeDelete: true)
                .ForeignKey("dbo.Collections", t => t.collectionID, cascadeDelete: true)
                .ForeignKey("dbo.Discounts", t => t.discountID, cascadeDelete: true)
                .Index(t => t.categoryID)
                .Index(t => t.discountID)
                .Index(t => t.collectionID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        categoryID = c.Int(nullable: false, identity: true),
                        categoryName = c.String(maxLength: 50),
                        categoryImageUrl = c.String(),
                        categoryStatu = c.Boolean(),
                    })
                .PrimaryKey(t => t.categoryID);
            
            CreateTable(
                "dbo.Collections",
                c => new
                    {
                        collectionID = c.Int(nullable: false, identity: true),
                        collectionName = c.String(maxLength: 50),
                        collectionStatu = c.Boolean(),
                    })
                .PrimaryKey(t => t.collectionID);
            
            CreateTable(
                "dbo.Discounts",
                c => new
                    {
                        discountID = c.Int(nullable: false, identity: true),
                        discountName = c.String(maxLength: 50),
                        discountCreatedDate = c.DateTime(),
                        discountRate = c.Single(),
                        discountStatu = c.Boolean(),
                    })
                .PrimaryKey(t => t.discountID);
            
            CreateTable(
                "dbo.Remands",
                c => new
                    {
                        remandID = c.Int(nullable: false, identity: true),
                        remandDate = c.DateTime(nullable: false),
                        remandReason = c.String(maxLength: 200),
                        RemandStatu = c.Boolean(),
                        preOrderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.remandID)
                .ForeignKey("dbo.PreOrders", t => t.preOrderID, cascadeDelete: true)
                .Index(t => t.preOrderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Remands", "preOrderID", "dbo.PreOrders");
            DropForeignKey("dbo.PreOrders", "productID", "dbo.Products");
            DropForeignKey("dbo.Products", "discountID", "dbo.Discounts");
            DropForeignKey("dbo.Products", "collectionID", "dbo.Collections");
            DropForeignKey("dbo.Products", "categoryID", "dbo.Categories");
            DropForeignKey("dbo.PreOrders", "paymentMethodID", "dbo.PaymentMethods");
            DropForeignKey("dbo.PreOrders", "customerID", "dbo.Customers");
            DropForeignKey("dbo.BankCards", "customerID", "dbo.Customers");
            DropForeignKey("dbo.Adresses", "customerID", "dbo.Customers");
            DropForeignKey("dbo.Admins", "customerID", "dbo.Customers");
            DropIndex("dbo.Remands", new[] { "preOrderID" });
            DropIndex("dbo.Products", new[] { "collectionID" });
            DropIndex("dbo.Products", new[] { "discountID" });
            DropIndex("dbo.Products", new[] { "categoryID" });
            DropIndex("dbo.PreOrders", new[] { "paymentMethodID" });
            DropIndex("dbo.PreOrders", new[] { "productID" });
            DropIndex("dbo.PreOrders", new[] { "customerID" });
            DropIndex("dbo.BankCards", new[] { "customerID" });
            DropIndex("dbo.Adresses", new[] { "customerID" });
            DropIndex("dbo.Admins", new[] { "customerID" });
            DropTable("dbo.Remands");
            DropTable("dbo.Discounts");
            DropTable("dbo.Collections");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.PaymentMethods");
            DropTable("dbo.PreOrders");
            DropTable("dbo.BankCards");
            DropTable("dbo.Adresses");
            DropTable("dbo.Customers");
            DropTable("dbo.Admins");
        }
    }
}
