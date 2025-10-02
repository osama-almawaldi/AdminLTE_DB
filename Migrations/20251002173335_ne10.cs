using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminLTE_DB.Migrations
{
    public partial class ne10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Uid",
                table: "Categories",
                newName: "uid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "uid",
                table: "Categories",
                newName: "Uid");
        }
    }
}
