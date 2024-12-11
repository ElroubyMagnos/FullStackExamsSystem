﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityBaseEE.Migrations
{
    /// <inheritdoc />
    public partial class shufflequestions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Shuffle",
                table: "Exams",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shuffle",
                table: "Exams");
        }
    }
}
