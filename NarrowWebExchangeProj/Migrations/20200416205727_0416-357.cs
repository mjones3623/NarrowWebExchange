using Microsoft.EntityFrameworkCore.Migrations;

namespace NarrowWebExchangeProj.Migrations
{
    public partial class _0416357 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50fe9e02-adcf-42a5-aef8-7fb73b503919");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c63d6040-be9a-4c05-8949-7701016e17a2");

            migrationBuilder.AddColumn<string>(
                name: "imb4",
                table: "Listing",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "img1",
                table: "Listing",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "img2",
                table: "Listing",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "img3",
                table: "Listing",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ef538e6-0477-4ef9-b4fe-f5a33d20ee5b", "af4976d8-b7cf-49ba-9348-0ed9abbb28d1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "967bfb21-8005-486f-880e-9c17686fe322", "8e60e040-3ffd-4421-99ae-5119391c7c16", "SiteUser", "SiteUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ef538e6-0477-4ef9-b4fe-f5a33d20ee5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "967bfb21-8005-486f-880e-9c17686fe322");

            migrationBuilder.DropColumn(
                name: "imb4",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "img1",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "img2",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "img3",
                table: "Listing");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50fe9e02-adcf-42a5-aef8-7fb73b503919", "ab5745da-60a5-4796-a053-b256391a5a6e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c63d6040-be9a-4c05-8949-7701016e17a2", "8d0b8450-d3a5-41d0-bf3b-17cae2d3fe27", "SiteUser", "SiteUser" });
        }
    }
}
