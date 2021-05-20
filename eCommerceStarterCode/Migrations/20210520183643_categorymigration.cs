using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class categorymigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94b25d94-8a15-4a8d-b9c7-305ec130787a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1c837c0-16bd-4c3e-b03c-1e2a521552ff");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Seasoned" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 11, 2, "you've GOAT to try it", "Goat -butter", 10.0 },
                    { 2, 2, "Your NEIGHbors will love it", "Horse-butter", 20.0 },
                    { 3, 2, "Other butter MOOve out of the way", "Cow-butter", 20.0 },
                    { 5, 3, "Will go back to solid during shipping", "Melted-butter", 60.0 },
                    { 7, 3, "Great snack after your Peleton workout", "Lifestyle-butter", 60.0 },
                    { 8, 2, "Greenland-shark-butter", "Norwegian-butter", 500.0 },
                    { 9, 3, "Godzilla's favorite butter (easter egg)", "Hokkaido-butter", 150.0 },
                    { 10, 3, "You don't have to share", "Hugo Chavez-butter", 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price" },
                values: new object[] { 4, 1, "We get it you're hip...", "Basil-gin infused butter", 80.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price" },
                values: new object[] { 6, 1, "You ever milk an almond....", "Almond-butter", 30.0 });
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
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1c837c0-16bd-4c3e-b03c-1e2a521552ff", "47726689-dfdb-4902-a3d6-89598bf2b767", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94b25d94-8a15-4a8d-b9c7-305ec130787a", "49a05c12-fa0d-4202-8981-6fc7d3d166ae", "Admin", "ADMIN" });
        }
    }
}
