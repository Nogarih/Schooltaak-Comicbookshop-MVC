using Microsoft.EntityFrameworkCore.Migrations;

namespace pe1.Webshop.Web.Migrations
{
    public partial class SeedDataSeries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "SerieName" },
                values: new object[,]
                {
                    { 1, "Attack on Titan" },
                    { 2, "My Hero Academia" },
                    { 3, "Castlevania" },
                    { 4, "Star Wars" },
                    { 5, "Marvel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
