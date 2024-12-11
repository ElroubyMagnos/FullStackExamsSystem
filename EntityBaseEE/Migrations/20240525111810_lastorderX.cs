using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityBaseEE.Migrations
{
    public partial class lastorderX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CanEnterQuestionsBank",
                table: "UserConts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "SubjectID",
                table: "RightWrongBank",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "RightWrongBank",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SubjectID",
                table: "EssayBank",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "EssayBank",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SubjectID",
                table: "ChooseBank",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "ChooseBank",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanEnterQuestionsBank",
                table: "UserConts");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "RightWrongBank");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "EssayBank");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "ChooseBank");

            migrationBuilder.AlterColumn<string>(
                name: "SubjectID",
                table: "RightWrongBank",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SubjectID",
                table: "EssayBank",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SubjectID",
                table: "ChooseBank",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
