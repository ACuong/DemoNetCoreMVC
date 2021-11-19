using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoDotNetMVC.Migrations
{
    public partial class Create_TableNhanVien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Person",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NhanVienId",
                table: "Person",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NhanVienName",
                table: "Person",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "NhanVienId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "NhanVienName",
                table: "Person");
        }
    }
}
