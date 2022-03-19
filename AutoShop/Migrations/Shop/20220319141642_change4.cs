using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoShop1.Migrations.Shop
{
    public partial class change4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "name_shop",
                columns: table => new
                {
                    nameShop = table.Column<string>(nullable: false),
                    id_shop = table.Column<int>(nullable: false),
                    city_shop = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_name_shop", x => x.nameShop);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "name_shop");
        }
    }
}
