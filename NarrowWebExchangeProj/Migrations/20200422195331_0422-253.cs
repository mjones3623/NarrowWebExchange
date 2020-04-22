using Microsoft.EntityFrameworkCore.Migrations;

namespace NarrowWebExchangeProj.Migrations
{
    public partial class _0422253 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "501e2c18-e8cc-4b77-88c7-020829ae6af0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9c24ba-aaa9-4625-a0c3-7ac0caaed916");

            migrationBuilder.AlterColumn<double>(
                name: "ReservePrice",
                table: "Listing",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "HighBidPrice",
                table: "Listing",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "DueSeller",
                table: "Listing",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "CurrentBid",
                table: "Listing",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Commission",
                table: "Listing",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "BuyItNowPrice",
                table: "Listing",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "326e159d-c7d8-4355-a9a9-fa71d4f2bcf6", "90dd217c-f220-45d8-9df0-bcebcf9776df", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4bdddd40-fd12-4f9d-bfdf-d6fa3de6de0c", "78d82dbb-1662-4c53-9015-ca4911308fba", "SiteUser", "SiteUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "326e159d-c7d8-4355-a9a9-fa71d4f2bcf6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4bdddd40-fd12-4f9d-bfdf-d6fa3de6de0c");

            migrationBuilder.AlterColumn<int>(
                name: "ReservePrice",
                table: "Listing",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "HighBidPrice",
                table: "Listing",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "DueSeller",
                table: "Listing",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "CurrentBid",
                table: "Listing",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "Commission",
                table: "Listing",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "BuyItNowPrice",
                table: "Listing",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca9c24ba-aaa9-4625-a0c3-7ac0caaed916", "a0d8bc89-9b0f-4777-aeb9-4a09ce736d61", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "501e2c18-e8cc-4b77-88c7-020829ae6af0", "a5687bff-1685-42b4-bc0e-d37f48838f9b", "SiteUser", "SiteUser" });
        }
    }
}
