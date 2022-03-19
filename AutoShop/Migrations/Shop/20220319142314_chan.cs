using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoShop1.Migrations.Shop
{
    public partial class chan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Shop",
                table: "Shop");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shop5",
                table: "Shop",
                column: "IdShop");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Shop5",
                table: "Shop");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shop",
                table: "Shop",
                column: "IdShop");
        }
    }
}
