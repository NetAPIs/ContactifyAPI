using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactifyAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixedBug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Proffesion",
                table: "Contacts",
                newName: "Profession");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Profession",
                table: "Contacts",
                newName: "Proffesion");
        }
    }
}
