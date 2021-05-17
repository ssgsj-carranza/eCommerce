using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a15a47e4-4531-4654-9cc0-2cb278cc1c1c", "03e201b2-9a69-491d-9ddb-81a77df454d4", "User", "USER" },
                    { "96ed7324-335d-4314-b1de-ca34d4de42ef", "06d5ebdf-68b5-4316-85d4-27ac6266acfb", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 11, "you've GOAT to try it", "Goat -butter", 10m },
                    { 2, "Your NEIGHbors will love it", "Horse-butter", 20m },
                    { 3, "Other butter MOOve out of the way", "Cow-butter", 20m },
                    { 4, "We get it you're hip...", "Basil-gin infused butter", 80m },
                    { 5, "Will go back to solid during shipping", "Melted-butter", 60m },
                    { 6, "You ever milk an almond....", "Almond-butter", 30m },
                    { 7, "Great snack after your Peleton workout", "Lifestyle-butter", 60m },
                    { 8, "Greenland-shark-butter", "Norwegian-butter", 500m },
                    { 9, "Godzilla's favorite butter (easter egg)", "Hokkaido-butter", 150m },
                    { 10, "You don't have to share", "Hugo Chavez-butter", 1m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ed7324-335d-4314-b1de-ca34d4de42ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a15a47e4-4531-4654-9cc0-2cb278cc1c1c");

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
        }
    }
}
