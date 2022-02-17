using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace February16.Migrations
{
    public partial class AddedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deliverys",
                columns: table => new
                {
                    DeliveryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HasDelivery = table.Column<bool>(type: "bit", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliverys", x => x.DeliveryId);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FoodCount = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    HasDelivery = table.Column<int>(type: "int", nullable: false, defaultValue: 2)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.CheckConstraint("FoodCount", "FoodCount > 0 AND FoodCount < 100");
                });

            migrationBuilder.CreateTable(
                name: "Shoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoesName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ShoesCount = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    HasDelivery = table.Column<int>(type: "int", nullable: false, defaultValue: 2)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoes", x => x.Id);
                    table.CheckConstraint("ShoesCount", "ShoesCount > 0 AND ShoesCount < 100");
                });

            migrationBuilder.InsertData(
                table: "Deliverys",
                columns: new[] { "DeliveryId", "HasDelivery" },
                values: new object[,]
                {
                    { 1, true },
                    { 2, false }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "FoodCount", "FoodName", "HasDelivery" },
                values: new object[,]
                {
                    { 1, 2, "Bread", 1 },
                    { 2, 2, "Milk", 2 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "FoodName" },
                values: new object[] { 3, "Cucumber" });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "HasDelivery", "ShoesCount", "ShoesName" },
                values: new object[,]
                {
                    { 1, 1, 1, "Nike" },
                    { 2, 1, 3, "Saucony" }
                });

            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "ShoesName" },
                values: new object[] { 3, "Adidas" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deliverys");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Shoes");
        }
    }
}
