using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class saveme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8c4d77d8-e220-430c-bbea-699d1ab7c87e", "0c1e6779-33b9-4250-92de-be2f8b4ca396", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "38477ed6-d189-45c7-a315-6ea390b71a58", "bf423d10-f09e-48d4-8486-309f951ecf9f", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38477ed6-d189-45c7-a315-6ea390b71a58");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c4d77d8-e220-430c-bbea-699d1ab7c87e");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Seasoned" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 11, 1, "you've GOAT to try it", "Goat -butter", 10.0 },
                    { 2, 1, "Your NEIGHbors will love it", "Horse-butter", 20.0 },
                    { 3, 1, "Other butter MOOve out of the way", "Cow-butter", 20.0 },
                    { 4, 1, "We get it you're hip...", "Basil-gin infused butter", 80.0 },
                    { 5, 1, "Will go back to solid during shipping", "Melted-butter", 60.0 },
                    { 6, 1, "You ever milk an almond....", "Almond-butter", 30.0 },
                    { 7, 1, "Great snack after your Peleton workout", "Lifestyle-butter", 60.0 },
                    { 8, 1, "Greenland-shark-butter", "Norwegian-butter", 500.0 },
                    { 9, 1, "Godzilla's favorite butter (easter egg)", "Hokkaido-butter", 150.0 },
                    { 10, 1, "You don't have to share", "Hugo Chavez-butter", 1.0 }
                });
        }
    }
}
