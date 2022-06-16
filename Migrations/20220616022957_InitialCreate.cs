using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIChallengeProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aircrafts",
                columns: table => new
                {
                    AircraftId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyHours = table.Column<double>(type: "float", nullable: false),
                    CurrentHours = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircrafts", x => x.AircraftId);
                });

            migrationBuilder.CreateTable(
                name: "AircraftTasks",
                columns: table => new
                {
                    ItemNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LogHours = table.Column<int>(type: "int", nullable: true),
                    IntervalMonths = table.Column<int>(type: "int", nullable: true),
                    IntervalHours = table.Column<int>(type: "int", nullable: true),
                    NextDue = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AircraftId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftTasks", x => x.ItemNumber);
                    table.ForeignKey(
                        name: "FK_AircraftTasks_Aircrafts_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircrafts",
                        principalColumn: "AircraftId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AircraftTasks_AircraftId",
                table: "AircraftTasks",
                column: "AircraftId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AircraftTasks");

            migrationBuilder.DropTable(
                name: "Aircrafts");
        }
    }
}
