using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoDotNetMVC.Migrations
{
    public partial class Create_Column_ChuýenSauChuyenNganh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChuyenSau",
                table: "ChuyenNganh",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChuyenSau",
                table: "ChuyenNganh");
        }
    }
}
