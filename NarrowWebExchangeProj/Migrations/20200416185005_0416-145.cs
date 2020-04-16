using Microsoft.EntityFrameworkCore.Migrations;

namespace NarrowWebExchangeProj.Migrations
{
    public partial class _0416145 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11e7098e-5212-429c-9a4f-f0cd3d1d849b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91d1ee02-dc7f-46f9-a324-89ad9258002c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50fe9e02-adcf-42a5-aef8-7fb73b503919", "ab5745da-60a5-4796-a053-b256391a5a6e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c63d6040-be9a-4c05-8949-7701016e17a2", "8d0b8450-d3a5-41d0-bf3b-17cae2d3fe27", "SiteUser", "SiteUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50fe9e02-adcf-42a5-aef8-7fb73b503919");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c63d6040-be9a-4c05-8949-7701016e17a2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11e7098e-5212-429c-9a4f-f0cd3d1d849b", "220b2233-e2fc-41d3-8722-5836b273efcf", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "91d1ee02-dc7f-46f9-a324-89ad9258002c", "1788fb7a-3688-4b3a-936f-c08cd8c23424", "SiteUser", "SiteUser" });
        }
    }
}
