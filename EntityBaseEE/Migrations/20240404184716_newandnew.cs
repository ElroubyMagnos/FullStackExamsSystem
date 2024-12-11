using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityBaseEE.Migrations
{
    /// <inheritdoc />
    public partial class newandnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DoctorUserName",
                table: "Exams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoctorUserName",
                table: "Exams");
        }
    }
}
