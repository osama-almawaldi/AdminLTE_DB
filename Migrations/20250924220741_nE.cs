using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminLTE_DB.Migrations
{
    public partial class nE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AddDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Islock",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UserDelete",
                table: "Employees",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Islock",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UserDelete",
                table: "Employees");
        }
    }
}
