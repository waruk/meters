using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Meters.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meters",
                columns: table => new
                {
                    MeterId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SerialNumber = table.Column<string>(maxLength: 50, nullable: true),
                    ResourceType = table.Column<int>(nullable: false),
                    Location = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meters", x => x.MeterId);
                });

            migrationBuilder.CreateTable(
                name: "Indexes",
                columns: table => new
                {
                    IndexId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RegisteredDate = table.Column<DateTime>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    MeterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indexes", x => x.IndexId);
                    table.ForeignKey(
                        name: "FK_Indexes_Meters_MeterId",
                        column: x => x.MeterId,
                        principalTable: "Meters",
                        principalColumn: "MeterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Meters",
                columns: new[] { "MeterId", "Location", "ResourceType", "SerialNumber" },
                values: new object[] { 1, 2, 2, "TestBathroomColdWater" });

            migrationBuilder.InsertData(
                table: "Meters",
                columns: new[] { "MeterId", "Location", "ResourceType", "SerialNumber" },
                values: new object[] { 2, 2, 1, "TestBathroomHotWater" });

            migrationBuilder.InsertData(
                table: "Meters",
                columns: new[] { "MeterId", "Location", "ResourceType", "SerialNumber" },
                values: new object[] { 3, 1, 2, "TestKitchenColdWater" });

            migrationBuilder.InsertData(
                table: "Meters",
                columns: new[] { "MeterId", "Location", "ResourceType", "SerialNumber" },
                values: new object[] { 4, 1, 1, "TestKitchenHotWater" });

            migrationBuilder.CreateIndex(
                name: "IX_Indexes_MeterId",
                table: "Indexes",
                column: "MeterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Indexes");

            migrationBuilder.DropTable(
                name: "Meters");
        }
    }
}
