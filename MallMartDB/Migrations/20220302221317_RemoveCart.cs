using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MallMartDB.Migrations
{
    public partial class RemoveCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCart",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IsCart",
                table: "AcquisitionOrders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCart",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCart",
                table: "AcquisitionOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
