using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CarsssDealer.Data.Migrations
{
    public partial class FinalFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartCarsss_Carsss_PartId",
                table: "PartCarsss");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Carsss_CarId",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carsss",
                table: "Carsss");

            migrationBuilder.RenameTable(
                name: "Carsss",
                newName: "Carsss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carsss",
                table: "Carsss",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PartCarsss_Carsss_PartId",
                table: "PartCarsss",
                column: "PartId",
                principalTable: "Carsss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Carsss_CarId",
                table: "Sales",
                column: "CarId",
                principalTable: "Carsss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartCarsss_Carsss_PartId",
                table: "PartCarsss");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Carsss_CarId",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carsss",
                table: "Carsss");

            migrationBuilder.RenameTable(
                name: "Carsss",
                newName: "Carsss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carsss",
                table: "Carsss",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PartCarsss_Carsss_PartId",
                table: "PartCarsss",
                column: "PartId",
                principalTable: "Carsss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Carsss_CarId",
                table: "Sales",
                column: "CarId",
                principalTable: "Carsss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
