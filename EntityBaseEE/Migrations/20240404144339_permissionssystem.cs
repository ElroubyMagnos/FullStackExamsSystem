using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityBaseEE.Migrations
{
    /// <inheritdoc />
    public partial class permissionssystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Permissions",
                table: "UserConts");

            migrationBuilder.RenameColumn(
                name: "IsAdmin",
                table: "UserConts",
                newName: "CanSignIn");

            migrationBuilder.AddColumn<bool>(
                name: "CanAddNewExams",
                table: "UserConts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanCreateAccounts",
                table: "UserConts",
                type: "bit",
                maxLength: 200,
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanDeleteAllExams",
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
                name: "CanEditAllStudentsData",
                table: "UserConts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanEnterCore",
                table: "UserConts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanEnterExamsWindow",
                table: "UserConts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanEnterSettings",
                table: "UserConts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CanEnterStudentWindow",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanAddNewExams",
                table: "UserConts");

            migrationBuilder.DropColumn(
                name: "CanCreateAccounts",
                table: "UserConts");

            migrationBuilder.DropColumn(
                name: "CanDeleteAllExams",
                table: "UserConts");

            migrationBuilder.DropColumn(
                name: "CanDeleteExams",
                table: "UserConts");

            migrationBuilder.DropColumn(
                name: "CanEditAllStudentsData",
                table: "UserConts");

            migrationBuilder.DropColumn(
                name: "CanEnterCore",
                table: "UserConts");

            migrationBuilder.DropColumn(
                name: "CanEnterExamsWindow",
                table: "UserConts");

            migrationBuilder.DropColumn(
                name: "CanEnterSettings",
                table: "UserConts");

            migrationBuilder.DropColumn(
                name: "CanEnterStudentWindow",
                table: "UserConts");

            migrationBuilder.DropColumn(
                name: "CanManageExams",
                table: "UserConts");

            migrationBuilder.DropColumn(
                name: "CanSeeResultsOfExams",
                table: "UserConts");

            migrationBuilder.RenameColumn(
                name: "CanSignIn",
                table: "UserConts",
                newName: "IsAdmin");

            migrationBuilder.AddColumn<string>(
                name: "Permissions",
                table: "UserConts",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }
    }
}
