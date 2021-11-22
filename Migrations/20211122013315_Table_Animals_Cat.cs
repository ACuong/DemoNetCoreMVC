using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoDotNetMVC.Migrations
{
    public partial class Table_Animals_Cat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChuyenNganh_Khoa_KhoaId",
                table: "ChuyenNganh");

            migrationBuilder.AlterColumn<int>(
                name: "KhoaId",
                table: "ChuyenNganh",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ChuyenNganh_Khoa_KhoaId",
                table: "ChuyenNganh",
                column: "KhoaId",
                principalTable: "Khoa",
                principalColumn: "KhoaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChuyenNganh_Khoa_KhoaId",
                table: "ChuyenNganh");

            migrationBuilder.AlterColumn<int>(
                name: "KhoaId",
                table: "ChuyenNganh",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_ChuyenNganh_Khoa_KhoaId",
                table: "ChuyenNganh",
                column: "KhoaId",
                principalTable: "Khoa",
                principalColumn: "KhoaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
