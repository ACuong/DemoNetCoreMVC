using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoDotNetMVC.Migrations
{
    public partial class Table_Khoa_ChuyenNganh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khoa",
                columns: table => new
                {
                    KhoaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KhoaName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoa", x => x.KhoaId);
                });

            migrationBuilder.CreateTable(
                name: "ChuyenNganh",
                columns: table => new
                {
                    ChuyenNganhId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChuyenNganhName = table.Column<string>(type: "TEXT", nullable: true),
                    KhoaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenNganh", x => x.ChuyenNganhId);
                    table.ForeignKey(
                        name: "FK_ChuyenNganh_Khoa_KhoaId",
                        column: x => x.KhoaId,
                        principalTable: "Khoa",
                        principalColumn: "KhoaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenNganh_KhoaId",
                table: "ChuyenNganh",
                column: "KhoaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChuyenNganh");

            migrationBuilder.DropTable(
                name: "Khoa");
        }
    }
}
