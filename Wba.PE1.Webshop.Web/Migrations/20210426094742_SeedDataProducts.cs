using Microsoft.EntityFrameworkCore.Migrations;

namespace pe1.Webshop.Web.Migrations
{
    public partial class SeedDataProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Image", "Price", "ProductName", "PublisherId", "SerieId" },
                values: new object[] { 1, 1, "attack-on-titan-vol-01.jpg", 11.95m, "Attack on Titan Vol 01", 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
