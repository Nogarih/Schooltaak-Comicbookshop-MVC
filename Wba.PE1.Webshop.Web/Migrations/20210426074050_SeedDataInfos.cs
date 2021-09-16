using Microsoft.EntityFrameworkCore.Migrations;

namespace pe1.Webshop.Web.Migrations
{
    public partial class SeedDataInfos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Infos",
                columns: new[] { "Id", "InfoText" },
                values: new object[,]
                {
                    { 1, "New 2021" },
                    { 15, "Adventure" },
                    { 14, "School" },
                    { 13, "Romance" },
                    { 12, "Horror" },
                    { 11, "Action" },
                    { 10, "Slice of life" },
                    { 16, "Fantasy" },
                    { 9, "Shoujo" },
                    { 7, "Upcomming" },
                    { 6, "Ongoing" },
                    { 5, "Finished" },
                    { 4, "Collectible" },
                    { 3, "Pre-Order" },
                    { 2, "Limited Edition" },
                    { 8, "Shonen" },
                    { 17, "Magic" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
