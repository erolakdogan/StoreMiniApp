using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreMiniApp.API.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsRatePercentage = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    OrderId = table.Column<int>(type: "int", maxLength: 25, nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductQuantity = table.Column<int>(type: "int", nullable: false),
                    DerivedProductCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDerivedCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "CreatedDate", "IsRatePercentage", "Name", "Rate", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Affiliate Discount", 10m, 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Employee Discount", 30m, 2 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Loyal Customer Discount", 5m, 3 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Price Discount", 5m, 4 }
                });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "CreatedDate", "InvoiceNumber", "OrderId", "OrderTotal", "Total", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BJK010", 1, 0m, 500m, 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BJK011", 2, 0m, 1500m, 2 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BJK012", 3, 0m, 990m, 3 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BJK013", 4, 0m, 920m, 4 }
                });

            migrationBuilder.InsertData(
                table: "InvoiceDetails",
                columns: new[] { "Id", "CreatedDate", "DerivedProductCost", "DiscountPrice", "InvoiceId", "ProductId", "ProductName", "ProductPrice", "ProductQuantity", "TotalDerivedCost" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 40m, 2m, 1, 2, "Item 2", 20m, 2, 38m },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 482m, 20m, 1, 4, "Item 4", 482m, 1, 462m },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, 0m, 2, 40, "Item 40", 50m, 5, 250m },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, 25m, 4, 3, "Item 3", 50m, 5, 225m },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 400m, 20m, 3, 5, "Item 5", 400m, 1, 380m },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 385m, 0m, 3, 15, "Item 15", 77m, 5, 385m },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000m, 80m, 4, 105, "Item 105", 200m, 5, 920m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedDate", "Email", "FirstName", "LastName", "PhoneNumber", "UserType" },
                values: new object[,]
                {
                    { 1, "İstanbul", new DateTime(2021, 5, 16, 6, 38, 56, 334, DateTimeKind.Local).AddTicks(2660), "sergen@email.com", "Sergen ", "Yalçın", "123456789", 1 },
                    { 2, "Samsun", new DateTime(2020, 5, 16, 6, 38, 56, 334, DateTimeKind.Local).AddTicks(2674), "ilhan@email.com", "İlhan ", "Mansız", "505542210", 1 },
                    { 3, "Ankara", new DateTime(2019, 5, 16, 6, 38, 56, 334, DateTimeKind.Local).AddTicks(2677), "metin@email.com", "Metin ", "Tekin", "504425102", 2 },
                    { 4, "İstanbul", new DateTime(2022, 2, 16, 6, 38, 56, 334, DateTimeKind.Local).AddTicks(2678), "ali@email.com", "Ali ", "Gültekin", "5057581801", 3 },
                    { 5, "İstanbul", new DateTime(2019, 5, 16, 6, 38, 56, 334, DateTimeKind.Local).AddTicks(2682), "feyyaz@email.com", "Feyyaz ", "Uçar", "5064581806", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "InvoiceDetails");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
