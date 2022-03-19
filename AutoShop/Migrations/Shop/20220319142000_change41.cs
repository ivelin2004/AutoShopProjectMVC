using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoShop1.Migrations.Shop
{
    public partial class change41 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_name_shop",
                table: "name_shop");

            migrationBuilder.RenameTable(
                name: "name_shop",
                newName: "Shop");

            migrationBuilder.RenameColumn(
                name: "city_shop",
                table: "Shop",
                newName: "cityShop");

            migrationBuilder.RenameColumn(
                name: "id_shop",
                table: "Shop",
                newName: "IdShop");

            migrationBuilder.AlterColumn<string>(
                name: "nameShop",
                table: "Shop",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "cityShop",
                table: "Shop",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdShop",
                table: "Shop",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shop",
                table: "Shop",
                column: "IdShop");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Shop",
                table: "Shop");

            migrationBuilder.RenameTable(
                name: "Shop",
                newName: "name_shop");

            migrationBuilder.RenameColumn(
                name: "cityShop",
                table: "name_shop",
                newName: "city_shop");

            migrationBuilder.RenameColumn(
                name: "IdShop",
                table: "name_shop",
                newName: "id_shop");

            migrationBuilder.AlterColumn<string>(
                name: "nameShop",
                table: "name_shop",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "city_shop",
                table: "name_shop",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_shop",
                table: "name_shop",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_name_shop",
                table: "name_shop",
                column: "nameShop");
        }
    }
}
