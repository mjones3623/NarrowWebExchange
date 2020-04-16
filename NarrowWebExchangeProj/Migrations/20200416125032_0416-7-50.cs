using Microsoft.EntityFrameworkCore.Migrations;

namespace NarrowWebExchangeProj.Migrations
{
    public partial class _0416750 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ab8e103-534a-4b26-8429-efdb525e45f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f00e13f-2992-4fbf-ba47-924739081326");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11e7098e-5212-429c-9a4f-f0cd3d1d849b", "220b2233-e2fc-41d3-8722-5836b273efcf", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "91d1ee02-dc7f-46f9-a324-89ad9258002c", "1788fb7a-3688-4b3a-936f-c08cd8c23424", "SiteUser", "SiteUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4ab8e103-534a-4b26-8429-efdb525e45f1", "c9b630d3-7831-4c2e-92b1-0ebd90fb974b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f00e13f-2992-4fbf-ba47-924739081326", "b0b8bd71-845d-465c-a353-9d5d0cf2f7e7", "SiteUser", "SiteUser" });
        }
    }
}
