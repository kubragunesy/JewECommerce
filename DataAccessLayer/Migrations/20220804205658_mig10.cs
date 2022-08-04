using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoryImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryID);
                });

            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    collectionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    collectionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.collectionID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerBirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    customerCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    customerImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerStatu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customerID);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    discountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    discountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    discountCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    discountRate = table.Column<float>(type: "real", nullable: false),
                    discountStatu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.discountID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    paymentMethodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paymentMethodName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.paymentMethodID);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    adminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adminStatu = table.Column<bool>(type: "bit", nullable: false),
                    customerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.adminID);
                    table.ForeignKey(
                        name: "FK_Admins_Customers_customerID",
                        column: x => x.customerID,
                        principalTable: "Customers",
                        principalColumn: "customerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    adressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adressName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adressLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.adressID);
                    table.ForeignKey(
                        name: "FK_Adresses_Customers_customerID",
                        column: x => x.customerID,
                        principalTable: "Customers",
                        principalColumn: "customerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankCards",
                columns: table => new
                {
                    bankCardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bankCardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bankCardNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bankCardType = table.Column<bool>(type: "bit", nullable: false),
                    bankCardExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankCards", x => x.bankCardID);
                    table.ForeignKey(
                        name: "FK_BankCards_Customers_customerID",
                        column: x => x.customerID,
                        principalTable: "Customers",
                        principalColumn: "customerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productUnitInStock = table.Column<short>(type: "smallint", nullable: false),
                    productUnitPrice = table.Column<int>(type: "int", nullable: false),
                    productDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoryID = table.Column<int>(type: "int", nullable: false),
                    discountID = table.Column<int>(type: "int", nullable: false),
                    collectionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.productID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_categoryID",
                        column: x => x.categoryID,
                        principalTable: "Categories",
                        principalColumn: "categoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Collections_collectionID",
                        column: x => x.collectionID,
                        principalTable: "Collections",
                        principalColumn: "collectionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Discounts_discountID",
                        column: x => x.discountID,
                        principalTable: "Discounts",
                        principalColumn: "discountID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreOrders",
                columns: table => new
                {
                    preOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    preOrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    preOrderDeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    preOrderQuantity = table.Column<int>(type: "int", nullable: false),
                    preOrderStatu = table.Column<byte>(type: "tinyint", nullable: false),
                    preOrderNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cartStatu = table.Column<bool>(type: "bit", nullable: false),
                    customerID = table.Column<int>(type: "int", nullable: false),
                    productID = table.Column<int>(type: "int", nullable: false),
                    paymentMethodID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreOrders", x => x.preOrderID);
                    table.ForeignKey(
                        name: "FK_PreOrders_Customers_customerID",
                        column: x => x.customerID,
                        principalTable: "Customers",
                        principalColumn: "customerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreOrders_PaymentMethods_paymentMethodID",
                        column: x => x.paymentMethodID,
                        principalTable: "PaymentMethods",
                        principalColumn: "paymentMethodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreOrders_Products_productID",
                        column: x => x.productID,
                        principalTable: "Products",
                        principalColumn: "productID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Remands",
                columns: table => new
                {
                    remandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    preOrderID = table.Column<int>(type: "int", nullable: false),
                    remandDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    remandReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RemandStatu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remands", x => x.remandID);
                    table.ForeignKey(
                        name: "FK_Remands_PreOrders_preOrderID",
                        column: x => x.preOrderID,
                        principalTable: "PreOrders",
                        principalColumn: "preOrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_customerID",
                table: "Admins",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_customerID",
                table: "Adresses",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_BankCards_customerID",
                table: "BankCards",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_PreOrders_customerID",
                table: "PreOrders",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_PreOrders_paymentMethodID",
                table: "PreOrders",
                column: "paymentMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_PreOrders_productID",
                table: "PreOrders",
                column: "productID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_categoryID",
                table: "Products",
                column: "categoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_collectionID",
                table: "Products",
                column: "collectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_discountID",
                table: "Products",
                column: "discountID");

            migrationBuilder.CreateIndex(
                name: "IX_Remands_preOrderID",
                table: "Remands",
                column: "preOrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Adresses");

            migrationBuilder.DropTable(
                name: "BankCards");

            migrationBuilder.DropTable(
                name: "Remands");

            migrationBuilder.DropTable(
                name: "PreOrders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.DropTable(
                name: "Discounts");
        }
    }
}
