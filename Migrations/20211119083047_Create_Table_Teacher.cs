using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoDotNetMVC.Migrations
{
    public partial class Create_Table_Teacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NhanVienName",
                table: "Person",
                newName: "DiaChi");

            migrationBuilder.RenameColumn(
                name: "NhanVienId",
                table: "Person",
                newName: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Person",
                newName: "NhanVienId");

            migrationBuilder.RenameColumn(
                name: "DiaChi",
                table: "Person",
                newName: "NhanVienName");
        }
    }
}
