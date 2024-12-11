using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityBaseEE.Migrations
{
    /// <inheritdoc />
    public partial class backandback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanAddNewExams",
                table: "UserConts");

            migrationBuilder.DropColumn(
                name: "CanDeleteExams",
                table: "UserConts");

            migrationBuilder.DropColumn(
                name: "CanManageExams",
                table: "UserConts");

            migrationBuilder.DropColumn(
                name: "CanSeeResultsOfExams",
                table: "UserConts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CanAddNewExams",
                table: "UserConts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanDeleteExams",
                table: "UserConts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanManageExams",
                table: "UserConts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanSeeResultsOfExams",
                table: "UserConts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
