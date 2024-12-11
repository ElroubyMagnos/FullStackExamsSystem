using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityBaseEE.Migrations
{
    public partial class points : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "RightWrongQuestions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "EssayQuestions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "ChooseQuestions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ChooseBank",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RightAnswer = table.Column<int>(type: "int", nullable: false),
                    FirstAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FourthAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChooseBank", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EssayBank",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EssayBank", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RightWrongBank",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RightAnswer = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RightWrongBank", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChooseBank");

            migrationBuilder.DropTable(
                name: "EssayBank");

            migrationBuilder.DropTable(
                name: "RightWrongBank");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "RightWrongQuestions");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "EssayQuestions");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "ChooseQuestions");
        }
    }
}
