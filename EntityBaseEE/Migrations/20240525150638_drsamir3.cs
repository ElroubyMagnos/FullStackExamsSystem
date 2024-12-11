using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityBaseEE.Migrations
{
    public partial class drsamir3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Right",
                table: "AnswersOfEssay");

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "AnswersOfEssay",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Points",
                table: "AnswersOfEssay");

            migrationBuilder.AddColumn<bool>(
                name: "Right",
                table: "AnswersOfEssay",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
