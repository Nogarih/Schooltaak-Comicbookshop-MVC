using Microsoft.EntityFrameworkCore.Migrations;

namespace pe1.Webshop.Web.Migrations
{
    public partial class SeedDataProductInfos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductInfos",
                columns: new[] { "ProductId", "InfoId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 8, 11 },
                    { 8, 12 },
                    { 8, 16 },
                    { 8, 17 },
                    { 9, 5 },
                    { 9, 11 },
                    { 9, 12 },
                    { 9, 16 },
                    { 9, 17 },
                    { 10, 1 },
                    { 10, 6 },
                    { 10, 8 },
                    { 10, 11 },
                    { 8, 5 },
                    { 10, 14 },
                    { 11, 3 },
                    { 11, 7 },
                    { 11, 11 },
                    { 11, 15 },
                    { 12, 1 },
                    { 12, 6 },
                    { 12, 8 },
                    { 12, 11 },
                    { 12, 14 },
                    { 13, 5 },
                    { 13, 11 },
                    { 13, 15 },
                    { 14, 5 },
                    { 10, 17 },
                    { 14, 11 },
                    { 7, 7 },
                    { 7, 3 },
                    { 2, 4 },
                    { 2, 11 },
                    { 2, 14 },
                    { 2, 8 },
                    { 3, 1 },
                    { 3, 6 },
                    { 3, 8 },
                    { 3, 11 },
                    { 3, 14 },
                    { 4, 2 },
                    { 4, 5 },
                    { 4, 8 },
                    { 4, 11 },
                    { 7, 4 },
                    { 4, 12 },
                    { 4, 16 },
                    { 5, 2 },
                    { 5, 5 },
                    { 5, 8 },
                    { 5, 11 },
                    { 5, 12 },
                    { 5, 15 },
                    { 5, 16 },
                    { 6, 3 },
                    { 6, 8 },
                    { 6, 13 },
                    { 6, 14 },
                    { 6, 17 },
                    { 4, 15 },
                    { 14, 15 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 4, 15 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 6, 17 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 8, 12 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 8, 16 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 8, 17 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 9, 11 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 9, 16 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 10, 14 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 10, 17 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 11, 15 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 12, 14 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 13, 11 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 13, 15 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 14, 11 });

            migrationBuilder.DeleteData(
                table: "ProductInfos",
                keyColumns: new[] { "ProductId", "InfoId" },
                keyValues: new object[] { 14, 15 });
        }
    }
}
