using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NarrowWebExchangeProj.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0125088d-b84f-49a2-869d-0df1ad3769f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24d1ba22-31e6-479a-b379-367bd9dc4a90");

            migrationBuilder.CreateTable(
                name: "Listing",
                columns: table => new
                {
                    ListingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellerUserId = table.Column<int>(nullable: false),
                    UserIdSiteUserId = table.Column<int>(nullable: true),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Hours = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false),
                    NumColors = table.Column<int>(nullable: false),
                    NumDieStations = table.Column<int>(nullable: false),
                    Condition = table.Column<string>(nullable: true),
                    ToolingIncluded = table.Column<string>(nullable: true),
                    FeaturesAndComments = table.Column<string>(nullable: true),
                    ListingType = table.Column<string>(nullable: true),
                    BuyItNowPrice = table.Column<int>(nullable: false),
                    ReservePrice = table.Column<int>(nullable: false),
                    ListingDateTime = table.Column<DateTime>(nullable: false),
                    ListingDays = table.Column<int>(nullable: false),
                    CurrentBid = table.Column<int>(nullable: false),
                    NumberOfBids = table.Column<int>(nullable: false),
                    HighBidPrice = table.Column<int>(nullable: false),
                    HighBidUserId = table.Column<int>(nullable: false),
                    ReserveMet = table.Column<bool>(nullable: false),
                    Commission = table.Column<int>(nullable: false),
                    DueSeller = table.Column<int>(nullable: false),
                    PaymentReceived = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listing", x => x.ListingId);
                    table.ForeignKey(
                        name: "FK_Listing_SiteUsers_UserIdSiteUserId",
                        column: x => x.UserIdSiteUserId,
                        principalTable: "SiteUsers",
                        principalColumn: "SiteUserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Makes",
                columns: table => new
                {
                    MakeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makes", x => x.MakeId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "79c8276b-4718-440c-8c06-93caf0ef91cd", "3303186c-2e25-4c3d-ae8d-370ea4fef7ec", "Admin", "ADMIN" },
                    { "7092d3d4-5cda-462a-81a0-a39a50bd0c2f", "77195c44-e62b-488d-bd26-87dbe572123a", "SiteUser", "SiteUser" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "MakeId", "MakeName" },
                values: new object[,]
                {
                    { 1, "Mark Andy" },
                    { 2, "Nilpeter" },
                    { 3, "Gallus" },
                    { 4, "Edale" },
                    { 5, "MPS" },
                    { 6, "Omet" },
                    { 7, "Aquaflex" },
                    { 8, "Allied Gear" },
                    { 9, "Roto-Press" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Listing_UserIdSiteUserId",
                table: "Listing",
                column: "UserIdSiteUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Listing");

            migrationBuilder.DropTable(
                name: "Makes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7092d3d4-5cda-462a-81a0-a39a50bd0c2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79c8276b-4718-440c-8c06-93caf0ef91cd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24d1ba22-31e6-479a-b379-367bd9dc4a90", "01f24479-2ea9-448b-8f14-6d228fa38193", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0125088d-b84f-49a2-869d-0df1ad3769f5", "009bd4d2-b2bb-4264-980c-68f6d4354311", "SiteUser", "SiteUser" });
        }
    }
}
