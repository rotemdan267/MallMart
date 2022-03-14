using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MallMartDB.Migrations
{
    public partial class RemoveDiscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountedPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsDiscounted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DiscountedPrice",
                table: "OrderLines");

            migrationBuilder.DropColumn(
                name: "IsDiscounted",
                table: "OrderLines");

            migrationBuilder.DropColumn(
                name: "DiscountedPrice",
                table: "AcquisitionOrderLines");

            migrationBuilder.DropColumn(
                name: "IsDiscounted",
                table: "AcquisitionOrderLines");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "DiscountedPrice",
                table: "Products",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDiscounted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "DiscountedPrice",
                table: "OrderLines",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDiscounted",
                table: "OrderLines",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "DiscountedPrice",
                table: "AcquisitionOrderLines",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDiscounted",
                table: "AcquisitionOrderLines",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
