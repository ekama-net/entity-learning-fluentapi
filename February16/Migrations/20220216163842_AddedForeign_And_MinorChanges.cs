using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace February16.Migrations
{
    public partial class AddedForeign_And_MinorChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Shoes_HasDelivery",
                table: "Shoes",
                column: "HasDelivery");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_HasDelivery",
                table: "Foods",
                column: "HasDelivery");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Deliverys_HasDelivery",
                table: "Foods",
                column: "HasDelivery",
                principalTable: "Deliverys",
                principalColumn: "DeliveryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Deliverys_HasDelivery",
                table: "Shoes",
                column: "HasDelivery",
                principalTable: "Deliverys",
                principalColumn: "DeliveryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Deliverys_HasDelivery",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Deliverys_HasDelivery",
                table: "Shoes");

            migrationBuilder.DropIndex(
                name: "IX_Shoes_HasDelivery",
                table: "Shoes");

            migrationBuilder.DropIndex(
                name: "IX_Foods_HasDelivery",
                table: "Foods");
        }
    }
}
