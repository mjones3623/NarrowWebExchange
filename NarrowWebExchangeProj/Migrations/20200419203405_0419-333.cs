﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NarrowWebExchangeProj.Migrations
{
    public partial class _0419333 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Searches",
                columns: table => new
                {
                    SearchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SearchSiteUserId = table.Column<int>(nullable: false),
                    SearchMake = table.Column<string>(nullable: true),
                    SearchModel = table.Column<string>(nullable: true),
                    SearchMinHours = table.Column<int>(nullable: false),
                    SearchMaxHours = table.Column<int>(nullable: false),
                    SearchFromYear = table.Column<int>(nullable: false),
                    SearchToYear = table.Column<int>(nullable: false),
                    SearchMinNumColors = table.Column<int>(nullable: false),
                    SearchMaxNumColors = table.Column<int>(nullable: false),
                    SearchMinNumDieStations = table.Column<int>(nullable: false),
                    SearchMaxNumDieStations = table.Column<int>(nullable: false),
                    SearchListingType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Searches", x => x.SearchId);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(nullable: true),
                    StateAbbreviation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteUsers",
                columns: table => new
                {
                    SiteUserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityUserId = table.Column<string>(nullable: true),
                    SiteUserFirstName = table.Column<string>(nullable: true),
                    SiteUserLastName = table.Column<string>(nullable: true),
                    SiteUserStreetAddress = table.Column<string>(nullable: true),
                    SiteUserCity = table.Column<string>(nullable: true),
                    SiteUserState = table.Column<string>(nullable: true),
                    SiteUserZipCode = table.Column<string>(nullable: true),
                    SiteUserPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteUsers", x => x.SiteUserId);
                    table.ForeignKey(
                        name: "FK_SiteUsers_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    PaymentReceived = table.Column<bool>(nullable: false),
                    Image1 = table.Column<string>(nullable: true),
                    Image2 = table.Column<string>(nullable: true),
                    Image3 = table.Column<string>(nullable: true),
                    Image4 = table.Column<string>(nullable: true)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "adcdd58a-0fd4-473a-b6fd-c739efc6c1ad", "47bc0c1d-ca2e-4106-83e9-2903047f2504", "Admin", "ADMIN" },
                    { "cc9bfb42-0753-4627-a728-19cd5bb8c14f", "624f09ac-d549-49de-b571-44a5f2398d25", "SiteUser", "SiteUser" }
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

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "MakeId", "MakeName" },
                values: new object[,]
                {
                    { 9, "Roto-Press" },
                    { 8, "Allied Gear" },
                    { 7, "Aquaflex" },
                    { 6, "Omet" },
                    { 5, "MPS" },
                    { 4, "Edale" },
                    { 3, "Gallus" },
                    { 2, "Nilpeter" },
                    { 1, "Mark Andy" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "StateId", "StateAbbreviation", "StateName" },
                values: new object[,]
                {
                    { 28, "NV", "Nevada" },
                    { 29, "NH", "New Hampshire" },
                    { 30, "NJ", "New Jersey" },
                    { 31, "NM", "New Mexico" },
                    { 32, "NY", "New York" },
                    { 33, "NC", "North Carolina" },
                    { 34, "ND", "North Dakota" },
                    { 35, "OH", "Ohio" },
                    { 36, "OK", "Oklahoma" },
                    { 37, "OR", "Oregon" },
                    { 38, "PA", "Pennsylvania" },
                    { 47, "WA", "Washington" },
                    { 40, "SC", "South Carolina" },
                    { 41, "SD", "South Dakota" },
                    { 42, "TN", "Tennessee" },
                    { 43, "TX", "Texas" },
                    { 44, "UT", "Utah" },
                    { 45, "VT", "Vermont" },
                    { 46, "VA", "Virginia" },
                    { 27, "NE", "Nebraska" },
                    { 48, "WV", "West Virginia" },
                    { 49, "WI", "Wisconsin" },
                    { 39, "RI", "Rhode Island" },
                    { 26, "MT", "Montana" },
                    { 16, "KS", "Kansas" },
                    { 24, "MS", "Mississippi" },
                    { 1, "AL", "Alabama" },
                    { 2, "AK", "Alaska" },
                    { 3, "AZ", "Arizona" },
                    { 4, "AR", "Arkansas" },
                    { 5, "CA", "California" },
                    { 6, "CO", "Colorado" },
                    { 7, "CT", "Connecticut" },
                    { 8, "DE", "Delaware" },
                    { 9, "FL", "Florida" },
                    { 10, "GA", "Georgia" },
                    { 11, "HI", "Hawaii" },
                    { 12, "ID", "Idaho" },
                    { 13, "IL", "Illinois" },
                    { 14, "IN", "Indiana" },
                    { 15, "IA", "Iowa" },
                    { 50, "WY", "Wyoming" },
                    { 17, "KY", "Kentucky" },
                    { 18, "LA", "Louisiana" },
                    { 19, "ME", "Maine" },
                    { 20, "MD", "Maryland" },
                    { 21, "MA", "Massachusetts" },
                    { 22, "MI", "Michigan" },
                    { 23, "MN", "Minnesota" },
                    { 25, "MO", "Missouri" },
                    { 51, "DC", "District of Columbia" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Listing_UserIdSiteUserId",
                table: "Listing",
                column: "UserIdSiteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteUsers_IdentityUserId",
                table: "SiteUsers",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "Listing");

            migrationBuilder.DropTable(
                name: "ListingTypes");

            migrationBuilder.DropTable(
                name: "Makes");

            migrationBuilder.DropTable(
                name: "Searches");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "SiteUsers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}