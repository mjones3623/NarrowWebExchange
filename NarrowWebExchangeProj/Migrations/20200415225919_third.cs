using Microsoft.EntityFrameworkCore.Migrations;

namespace NarrowWebExchangeProj.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7092d3d4-5cda-462a-81a0-a39a50bd0c2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79c8276b-4718-440c-8c06-93caf0ef91cd");

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    ConditionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.ConditionId);
                });

            migrationBuilder.CreateTable(
                name: "ListingTypes",
                columns: table => new
                {
                    ListingTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListingTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingTypes", x => x.ListingTypeId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4ab8e103-534a-4b26-8429-efdb525e45f1", "c9b630d3-7831-4c2e-92b1-0ebd90fb974b", "Admin", "ADMIN" },
                    { "6f00e13f-2992-4fbf-ba47-924739081326", "b0b8bd71-845d-465c-a353-9d5d0cf2f7e7", "SiteUser", "SiteUser" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "ConditionId", "ConditionName" },
                values: new object[,]
                {
                    { 1, "Excellent" },
                    { 2, "Good" },
                    { 3, "Needs Minor Repair" },
                    { 4, "Needs Major Repair" },
                    { 5, "Parts" }
                });

            migrationBuilder.InsertData(
                table: "ListingTypes",
                columns: new[] { "ListingTypeId", "ListingTypeName" },
                values: new object[,]
                {
                    { 1, "BuyItNow" },
                    { 2, "BuyItNow With Auction" },
                    { 3, "Auction" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "ListingTypes");

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
                values: new object[] { "79c8276b-4718-440c-8c06-93caf0ef91cd", "3303186c-2e25-4c3d-ae8d-370ea4fef7ec", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7092d3d4-5cda-462a-81a0-a39a50bd0c2f", "77195c44-e62b-488d-bd26-87dbe572123a", "SiteUser", "SiteUser" });
        }
    }
}
