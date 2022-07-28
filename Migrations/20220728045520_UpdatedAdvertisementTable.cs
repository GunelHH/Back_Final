using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Migrations
{
    public partial class UpdatedAdvertisementTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Order",
                table: "Advertisements",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Advertisements");
        }
    }
}
