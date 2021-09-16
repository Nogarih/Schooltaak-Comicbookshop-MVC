using Microsoft.EntityFrameworkCore.Migrations;

namespace pe1.Webshop.Web.Migrations
{
    public partial class SeedDataProductInfos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductInfos",
                columns: new[] { "ProductId", "InfoId" },
                values: new object[,]
                {
                    { 1, 6 },
                    { 1, 8 },
                    { 1, 11 },
                    { 1, 12 },
                    { 1, 15 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 1, 15 });
        }
    }
}
