using Microsoft.EntityFrameworkCore.Migrations;

namespace NarrowWebExchangeProj.Migrations
{
    public partial class _0421704 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adcdd58a-0fd4-473a-b6fd-c739efc6c1ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc9bfb42-0753-4627-a728-19cd5bb8c14f");

            migrationBuilder.AddColumn<int>(
                name: "SearchMaxWidth",
                table: "Searches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SearchMinWidth",
                table: "Searches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6ad02cf-8b15-43d1-91a9-ebc0b8a71da7", "7b0c02bc-c5ff-433c-bc7f-33a6a5a6544f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "909a9928-951b-4388-86fe-ed2122b9d3d2", "f14d279c-c797-4628-aa6f-5bf949bc8e50", "SiteUser", "SiteUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "909a9928-951b-4388-86fe-ed2122b9d3d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6ad02cf-8b15-43d1-91a9-ebc0b8a71da7");

            migrationBuilder.DropColumn(
                name: "SearchMaxWidth",
                table: "Searches");

            migrationBuilder.DropColumn(
                name: "SearchMinWidth",
                table: "Searches");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "adcdd58a-0fd4-473a-b6fd-c739efc6c1ad", "47bc0c1d-ca2e-4106-83e9-2903047f2504", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc9bfb42-0753-4627-a728-19cd5bb8c14f", "624f09ac-d549-49de-b571-44a5f2398d25", "SiteUser", "SiteUser" });
        }
    }
}
