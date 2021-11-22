using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoDotNetMVC.Migrations
{
    public partial class update_Table_Cat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatName",
                table: "Animal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CatName",
                table: "Animal",
                type: "TEXT",
                nullable: true);
        }
    }
}
