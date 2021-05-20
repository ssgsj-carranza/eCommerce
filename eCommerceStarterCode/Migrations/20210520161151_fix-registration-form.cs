using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class fixregistrationform : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1c837c0-16bd-4c3e-b03c-1e2a521552ff", "47726689-dfdb-4902-a3d6-89598bf2b767", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94b25d94-8a15-4a8d-b9c7-305ec130787a", "49a05c12-fa0d-4202-8981-6fc7d3d166ae", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8c4d77d8-e220-430c-bbea-699d1ab7c87e", "0c1e6779-33b9-4250-92de-be2f8b4ca396", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "38477ed6-d189-45c7-a315-6ea390b71a58", "bf423d10-f09e-48d4-8486-309f951ecf9f", "Admin", "ADMIN" });
        }
    }
}
