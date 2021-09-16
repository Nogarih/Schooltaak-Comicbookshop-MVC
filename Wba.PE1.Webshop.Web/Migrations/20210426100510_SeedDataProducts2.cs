using Microsoft.EntityFrameworkCore.Migrations;

namespace pe1.Webshop.Web.Migrations
{
    public partial class SeedDataProducts2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Image", "Price", "ProductName", "PublisherId", "SerieId" },
                values: new object[,]
                {
                    { 2, 3, "shoto-todoroki-statue-1.jpg", 43m, "Shoto Todoroki PVC Figure", 2, 2 },
                    { 3, 1, "MHA-28-manga.jpg", 9.99m, "My Hero Academia Vol 28", 2, 2 },
                    { 4, 2, "AOTSE1.jpg", 30.99m, "Attack on Titan SE01 DVD", 1, 1 },
                    { 5, 2, "AOTSE2.jpg", 24.95m, "Attack on Titan SE02 DVD", 1, 1 },
                    { 6, 3, "MHA-Dabi.jpg", 59m, "Dabi PVC figure", 2, 2 },
                    { 7, 3, "SWFigure.jpg", 285m, "Darth Vader statue", 3, 4 },
                    { 8, 4, "SW-vol38.jpg", 19.85m, "Star Wars Vol 38", 3, 4 },
                    { 9, 2, "castlevania-season-03-dvd.jpg", 27m, "Castlevania Season 03", 3, 3 },
                    { 10, 2, "mha_SE2_anime.jpg", 43.95m, "My Hero Academia Season 2", 2, 2 },
                    { 11, 4, "Star Wars Bounty.jpg", 16.99m, "Star Wars Bounty Hunters", 3, 4 },
                    { 12, 1, "MHAVOL11.jpg", 6.75m, "My Hero Academia Vol 11", 2, 2 },
                    { 13, 4, "Wolverine.jpg", 17.99m, "Death of Wolverine", 3, 5 },
                    { 14, 4, "deadpool-6.jpg", 12m, "Deadpool Vol 06", 3, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);
        }
    }
}
