using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityBaseEE.Migrations
{
    public partial class fixbugs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "student",
                table: "AnswersOfEssay");

            migrationBuilder.AddColumn<string>(
                name: "studentname",
                table: "AnswersOfEssay",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "studentname",
                table: "AnswersOfEssay");

            migrationBuilder.AddColumn<int>(
                name: "student",
                table: "AnswersOfEssay",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
