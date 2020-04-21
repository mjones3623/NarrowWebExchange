using Microsoft.EntityFrameworkCore.Migrations;

namespace NarrowWebExchangeProj.Migrations
{
    public partial class _0421105 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5748b51a-ea09-470c-bd68-4ef4911acde0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "982ba637-4472-4d3d-b66a-dc110ac87c2f");

            migrationBuilder.AddColumn<bool>(
                name: "TimedOurNoSale",
                table: "Listing",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eaeeb706-7627-433d-9a89-5dff36eaaee1", "c75661c6-4cb8-44c3-83a8-de95c0e81b72", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "326477f5-6793-43ff-9efd-fc55be3cb3e5", "c8089fe9-24c8-42b3-a273-3d29fe5f7fe2", "SiteUser", "SiteUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "326477f5-6793-43ff-9efd-fc55be3cb3e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eaeeb706-7627-433d-9a89-5dff36eaaee1");

            migrationBuilder.DropColumn(
                name: "TimedOurNoSale",
                table: "Listing");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "982ba637-4472-4d3d-b66a-dc110ac87c2f", "d7d906bf-c822-4e9e-aea1-a62d41ddf120", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5748b51a-ea09-470c-bd68-4ef4911acde0", "7e7044b7-8875-49cf-a32b-c7d8d08bf348", "SiteUser", "SiteUser" });
        }
    }
}
