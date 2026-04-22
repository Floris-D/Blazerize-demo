using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blazerize_demo.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Wagen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Kenteken = table.Column<string>(type: "TEXT", nullable: false),
                    Versie = table.Column<string>(type: "TEXT", nullable: false),
                    Diftar = table.Column<int>(type: "INTEGER", nullable: false),
                    CreateDatum = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdateDatum = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wagen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Datum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WagenKey = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotaalKg = table.Column<int>(type: "INTEGER", nullable: false),
                    CreateDatum = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdateDatum = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Datum_Wagen_WagenKey",
                        column: x => x.WagenKey,
                        principalTable: "Wagen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Label",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WagenKey = table.Column<int>(type: "INTEGER", nullable: false),
                    isActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Label", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Label_Wagen_WagenKey",
                        column: x => x.WagenKey,
                        principalTable: "Wagen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Wagen",
                columns: new[] { "Id", "CreateDatum", "Diftar", "Kenteken", "UpdateDatum", "Versie" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "11-TST-1", new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test" },
                    { 2, new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "22-TST-2", new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test" },
                    { 3, new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "33-TST-3", new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test" }
                });

            migrationBuilder.InsertData(
                table: "Datum",
                columns: new[] { "Id", "CreateDatum", "Date", "TotaalKg", "UpdateDatum", "WagenKey" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, null, 1 },
                    { 2, null, new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, null, 1 },
                    { 3, null, new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, null, 2 },
                    { 4, null, new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, null, 2 },
                    { 5, null, new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, null, 3 },
                    { 6, null, new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Label",
                columns: new[] { "Id", "Name", "WagenKey", "isActive" },
                values: new object[,]
                {
                    { 1, "GFT", 1, false },
                    { 2, "PMD", 1, true },
                    { 3, "GFT", 2, true },
                    { 4, "PMD", 2, true },
                    { 5, "GFT", 3, false },
                    { 6, "PMD", 3, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Datum_WagenKey",
                table: "Datum",
                column: "WagenKey");

            migrationBuilder.CreateIndex(
                name: "IX_Label_WagenKey",
                table: "Label",
                column: "WagenKey");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Datum");

            migrationBuilder.DropTable(
                name: "Label");

            migrationBuilder.DropTable(
                name: "Wagen");
        }
    }
}
