using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CarsssDealer.Data.Migrations
{
    public partial class CreateCarsss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Suppliers_SuppliersId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Customers_CustomersId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_CustomersId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Parts_SuppliersId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "CustomersId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "SuppliersId",
                table: "Parts");

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Parts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Carsss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Make = table.Column<string>(maxLength: 50, nullable: false),
                    Model = table.Column<string>(maxLength: 50, nullable: false),
                    TravelledDistance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carsss", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CarId",
                table: "Sales",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_SupplierId",
                table: "Parts",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Suppliers_SupplierId",
                table: "Parts",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Carsss_CarId",
                table: "Sales",
                column: "CarId",
                principalTable: "Carsss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Customers_CustomerId",
                table: "Sales",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Suppliers_SupplierId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Carsss_CarId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Customers_CustomerId",
                table: "Sales");

            migrationBuilder.DropTable(
                name: "Carsss");

            migrationBuilder.DropIndex(
                name: "IX_Sales_CarId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Parts_SupplierId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Parts");

            migrationBuilder.AddColumn<int>(
                name: "CustomersId",
                table: "Sales",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SuppliersId",
                table: "Parts",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomersId",
                table: "Sales",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_SuppliersId",
                table: "Parts",
                column: "SuppliersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Suppliers_SuppliersId",
                table: "Parts",
                column: "SuppliersId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Customers_CustomersId",
                table: "Sales",
                column: "CustomersId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
