using Microsoft.EntityFrameworkCore.Migrations;

namespace NarrowWebExchangeProj.Migrations
{
    public partial class _0421101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "909a9928-951b-4388-86fe-ed2122b9d3d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6ad02cf-8b15-43d1-91a9-ebc0b8a71da7");

            migrationBuilder.AddColumn<bool>(
                name: "ItemSold",
                table: "Listing",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "982ba637-4472-4d3d-b66a-dc110ac87c2f", "d7d906bf-c822-4e9e-aea1-a62d41ddf120", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5748b51a-ea09-470c-bd68-4ef4911acde0", "7e7044b7-8875-49cf-a32b-c7d8d08bf348", "SiteUser", "SiteUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5748b51a-ea09-470c-bd68-4ef4911acde0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "982ba637-4472-4d3d-b66a-dc110ac87c2f");

            migrationBuilder.DropColumn(
                name: "ItemSold",
                table: "Listing");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6ad02cf-8b15-43d1-91a9-ebc0b8a71da7", "7b0c02bc-c5ff-433c-bc7f-33a6a5a6544f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "909a9928-951b-4388-86fe-ed2122b9d3d2", "f14d279c-c797-4628-aa6f-5bf949bc8e50", "SiteUser", "SiteUser" });
        }
    }
}
