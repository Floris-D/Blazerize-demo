using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazerize_demo.Migrations
{
    /// <inheritdoc />
    public partial class AddDiftar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Diftar",
                table: "Wagens",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diftar",
                table: "Wagens");
        }
    }
}
