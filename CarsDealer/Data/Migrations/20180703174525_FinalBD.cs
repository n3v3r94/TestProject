using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CarsssDealer.Data.Migrations
{
    public partial class FinalBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PartCarsssId",
                table: "Parts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PartCarsss",
                columns: table => new
                {
                    PartId = table.Column<int>(nullable: false),
                    CarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartCarsss", x => new { x.PartId, x.CarId });
                    table.ForeignKey(
                        name: "FK_PartCarsss_Parts_CarId",
                        column: x => x.CarId,
                        principalTable: "Parts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartCarsss_Carsss_PartId",
                        column: x => x.PartId,
                        principalTable: "Carsss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartCarsss_CarId",
                table: "PartCarsss",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartCarsss");

            migrationBuilder.DropColumn(
                name: "PartCarsssId",
                table: "Parts");
        }
    }
}
