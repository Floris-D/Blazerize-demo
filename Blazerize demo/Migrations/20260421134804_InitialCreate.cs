using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazerize_demo.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Wagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Kenteken = table.Column<string>(type: "TEXT", nullable: false),
                    Versie = table.Column<string>(type: "TEXT", nullable: false),
                    Online = table.Column<bool>(type: "INTEGER", nullable: false),
                    Lock = table.Column<bool>(type: "INTEGER", nullable: false),
                    GeldigeLedigingen = table.Column<int>(type: "INTEGER", nullable: false),
                    NoReads = table.Column<int>(type: "INTEGER", nullable: false),
                    BlacklistContainers = table.Column<int>(type: "INTEGER", nullable: false),
                    TotaalKg = table.Column<int>(type: "INTEGER", nullable: false),
                    CreateDatum = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UpdateDatum = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wagens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Label",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    isActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    WagenId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Label", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Label_Wagens_WagenId",
                        column: x => x.WagenId,
                        principalTable: "Wagens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Label_WagenId",
                table: "Label",
                column: "WagenId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Label");

            migrationBuilder.DropTable(
                name: "Wagens");
        }
    }
}
