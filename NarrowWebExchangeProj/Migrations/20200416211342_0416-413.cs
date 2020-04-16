using Microsoft.EntityFrameworkCore.Migrations;

namespace NarrowWebExchangeProj.Migrations
{
    public partial class _0416413 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Listing",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Listing",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Listing",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "Listing",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2509cdab-94de-470e-8dfb-1b6419d145b9", "4ace5bb3-c54a-480e-8238-3a480a983bbb", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b6e9d89-db60-49f5-931a-5088de3d4d70", "fb171a22-b6e5-4a3e-9628-6675471aec73", "SiteUser", "SiteUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2509cdab-94de-470e-8dfb-1b6419d145b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b6e9d89-db60-49f5-931a-5088de3d4d70");

            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Listing");

            migrationBuilder.AddColumn<string>(
                name: "imb4",
                table: "Listing",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "img1",
                table: "Listing",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "img2",
                table: "Listing",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "img3",
                table: "Listing",
                type: "nvarchar(max)",
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
    }
}
