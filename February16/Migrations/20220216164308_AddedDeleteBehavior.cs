using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace February16.Migrations
{
    public partial class AddedDeleteBehavior : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Deliverys_HasDelivery",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Deliverys_HasDelivery",
                table: "Shoes");

            migrationBuilder.AlterColumn<int>(
                name: "HasDelivery",
                table: "Shoes",
                type: "int",
                nullable: true,
                defaultValue: 2,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "HasDelivery",
                table: "Foods",
                type: "int",
                nullable: true,
                defaultValue: 2,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 2);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "HasDelivery",
                value: null);

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "HasDelivery",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Deliverys_HasDelivery",
                table: "Foods",
                column: "HasDelivery",
                principalTable: "Deliverys",
                principalColumn: "DeliveryId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Deliverys_HasDelivery",
                table: "Shoes",
                column: "HasDelivery",
                principalTable: "Deliverys",
                principalColumn: "DeliveryId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Deliverys_HasDelivery",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Deliverys_HasDelivery",
                table: "Shoes");

            migrationBuilder.AlterColumn<int>(
                name: "HasDelivery",
                table: "Shoes",
                type: "int",
                nullable: false,
                defaultValue: 2,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "HasDelivery",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 2,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 2);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "HasDelivery",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "HasDelivery",
                value: 0);

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
    }
}
