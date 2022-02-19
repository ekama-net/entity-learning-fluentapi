using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace February16.Migrations
{
    public partial class AddedTPT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Shoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SoleType",
                table: "Shoes",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Discriminator", "ShoesName", "SoleType" },
                values: new object[] { 4, "RunningShoes", "Adidas", "plastic" });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Discriminator", "ShoesCount", "ShoesName", "SoleType" },
                values: new object[] { 5, "RunningShoes", 5, "Puma", "rubber" });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Discriminator", "HasDelivery", "ShoesCount", "ShoesName" },
                values: new object[,]
                {
                    { 1, "Shoes", 1, 1, "Nike" },
                    { 2, "Shoes", 1, 3, "Saucony" }
                });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Discriminator", "ShoesName" },
                values: new object[] { 3, "Shoes", "Adidas" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "SoleType",
                table: "Shoes");
        }
    }
}
