using Microsoft.EntityFrameworkCore.Migrations;

namespace NarrowWebExchangeProj.Migrations
{
    public partial class _0422129 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c46eb81-bd84-4bea-8c4b-f9d14328d59a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6678d3e-7b28-482b-9a27-f25cf4afd61b");

            migrationBuilder.DropColumn(
                name: "TimedOurNoSale",
                table: "Listing");

            migrationBuilder.AddColumn<bool>(
                name: "TimedOutNoSale",
                table: "Listing",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca9c24ba-aaa9-4625-a0c3-7ac0caaed916", "a0d8bc89-9b0f-4777-aeb9-4a09ce736d61", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "501e2c18-e8cc-4b77-88c7-020829ae6af0", "a5687bff-1685-42b4-bc0e-d37f48838f9b", "SiteUser", "SiteUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "501e2c18-e8cc-4b77-88c7-020829ae6af0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9c24ba-aaa9-4625-a0c3-7ac0caaed916");

            migrationBuilder.DropColumn(
                name: "TimedOutNoSale",
                table: "Listing");

            migrationBuilder.AddColumn<bool>(
                name: "TimedOurNoSale",
                table: "Listing",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e6678d3e-7b28-482b-9a27-f25cf4afd61b", "f3aad25f-2d5e-46ac-b216-2d8394575f97", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c46eb81-bd84-4bea-8c4b-f9d14328d59a", "7069754f-b53d-4fb5-89c7-f9cc1f5fb03f", "SiteUser", "SiteUser" });
        }
    }
}
