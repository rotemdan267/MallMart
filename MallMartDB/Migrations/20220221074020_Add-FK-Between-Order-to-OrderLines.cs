using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MallMartDB.Migrations
{
    public partial class AddFKBetweenOrdertoOrderLines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcquisitionOrderLines_AcquisitionOrders_AcquisitionOrderId",
                table: "AcquisitionOrderLines");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_ProductId",
                table: "OrderLines",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AcquisitionOrderLines_ProductId",
                table: "AcquisitionOrderLines",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_AcquisitionOrderLine_AcquisitionOrder",
                table: "AcquisitionOrderLines",
                column: "AcquisitionOrderId",
                principalTable: "AcquisitionOrders",
                principalColumn: "AcquisitionOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_AcquisitionOrderLines_Products_ProductId",
                table: "AcquisitionOrderLines",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLine_Order",
                table: "OrderLines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Products_ProductId",
                table: "OrderLines",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcquisitionOrderLine_AcquisitionOrder",
                table: "AcquisitionOrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_AcquisitionOrderLines_Products_ProductId",
                table: "AcquisitionOrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLine_Order",
                table: "OrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Products_ProductId",
                table: "OrderLines");

            migrationBuilder.DropIndex(
                name: "IX_OrderLines_ProductId",
                table: "OrderLines");

            migrationBuilder.DropIndex(
                name: "IX_AcquisitionOrderLines_ProductId",
                table: "AcquisitionOrderLines");

            migrationBuilder.AddForeignKey(
                name: "FK_AcquisitionOrderLines_AcquisitionOrders_AcquisitionOrderId",
                table: "AcquisitionOrderLines",
                column: "AcquisitionOrderId",
                principalTable: "AcquisitionOrders",
                principalColumn: "AcquisitionOrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
