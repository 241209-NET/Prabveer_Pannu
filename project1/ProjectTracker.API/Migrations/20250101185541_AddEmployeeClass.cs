using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectTracker.API.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Pets");

            migrationBuilder.AddColumn<int>(
                name: "Team_Id",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Team_Id",
                table: "Pets");

            migrationBuilder.AddColumn<DateOnly>(
                name: "Birthday",
                table: "Pets",
                type: "date",
                nullable: true);
        }
    }
}
