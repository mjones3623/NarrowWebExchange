﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NarrowWebExchangeProj.Data;

namespace NarrowWebExchangeProj.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200421180156_0421-101")]
    partial class _0421101
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "982ba637-4472-4d3d-b66a-dc110ac87c2f",
                            ConcurrencyStamp = "d7d906bf-c822-4e9e-aea1-a62d41ddf120",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "5748b51a-ea09-470c-bd68-4ef4911acde0",
                            ConcurrencyStamp = "7e7044b7-8875-49cf-a32b-c7d8d08bf348",
                            Name = "SiteUser",
                            NormalizedName = "SiteUser"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("NarrowWebExchangeProj.Models.Condition", b =>
                {
                    b.Property<int>("ConditionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConditionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConditionId");

                    b.ToTable("Conditions");

                    b.HasData(
                        new
                        {
                            ConditionId = 1,
                            ConditionName = "Excellent"
                        },
                        new
                        {
                            ConditionId = 2,
                            ConditionName = "Good"
                        },
                        new
                        {
                            ConditionId = 3,
                            ConditionName = "Needs Minor Repair"
                        },
                        new
                        {
                            ConditionId = 4,
                            ConditionName = "Needs Major Repair"
                        },
                        new
                        {
                            ConditionId = 5,
                            ConditionName = "Parts"
                        });
                });

            modelBuilder.Entity("NarrowWebExchangeProj.Models.Listing", b =>
                {
                    b.Property<int>("ListingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuyItNowPrice")
                        .HasColumnType("int");

                    b.Property<int>("Commission")
                        .HasColumnType("int");

                    b.Property<string>("Condition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CurrentBid")
                        .HasColumnType("int");

                    b.Property<int>("DueSeller")
                        .HasColumnType("int");

                    b.Property<string>("FeaturesAndComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HighBidPrice")
                        .HasColumnType("int");

                    b.Property<int>("HighBidUserId")
                        .HasColumnType("int");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<string>("Image1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ItemSold")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ListingDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ListingDays")
                        .HasColumnType("int");

                    b.Property<string>("ListingType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumColors")
                        .HasColumnType("int");

                    b.Property<int>("NumDieStations")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfBids")
                        .HasColumnType("int");

                    b.Property<bool>("PaymentReceived")
                        .HasColumnType("bit");

                    b.Property<bool>("ReserveMet")
                        .HasColumnType("bit");

                    b.Property<int>("ReservePrice")
                        .HasColumnType("int");

                    b.Property<int>("SellerUserId")
                        .HasColumnType("int");

                    b.Property<string>("ToolingIncluded")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserIdSiteUserId")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ListingId");

                    b.HasIndex("UserIdSiteUserId");

                    b.ToTable("Listing");
                });

            modelBuilder.Entity("NarrowWebExchangeProj.Models.ListingType", b =>
                {
                    b.Property<int>("ListingTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ListingTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ListingTypeId");

                    b.ToTable("ListingTypes");

                    b.HasData(
                        new
                        {
                            ListingTypeId = 1,
                            ListingTypeName = "BuyItNow"
                        },
                        new
                        {
                            ListingTypeId = 2,
                            ListingTypeName = "BuyItNow With Auction"
                        },
                        new
                        {
                            ListingTypeId = 3,
                            ListingTypeName = "Auction"
                        });
                });

            modelBuilder.Entity("NarrowWebExchangeProj.Models.Make", b =>
                {
                    b.Property<int>("MakeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MakeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MakeId");

                    b.ToTable("Makes");

                    b.HasData(
                        new
                        {
                            MakeId = 1,
                            MakeName = "Mark Andy"
                        },
                        new
                        {
                            MakeId = 2,
                            MakeName = "Nilpeter"
                        },
                        new
                        {
                            MakeId = 3,
                            MakeName = "Gallus"
                        },
                        new
                        {
                            MakeId = 4,
                            MakeName = "Edale"
                        },
                        new
                        {
                            MakeId = 5,
                            MakeName = "MPS"
                        },
                        new
                        {
                            MakeId = 6,
                            MakeName = "Omet"
                        },
                        new
                        {
                            MakeId = 7,
                            MakeName = "Aquaflex"
                        },
                        new
                        {
                            MakeId = 8,
                            MakeName = "Allied Gear"
                        },
                        new
                        {
                            MakeId = 9,
                            MakeName = "Roto-Press"
                        });
                });

            modelBuilder.Entity("NarrowWebExchangeProj.Models.Search", b =>
                {
                    b.Property<int>("SearchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SearchFromYear")
                        .HasColumnType("int");

                    b.Property<string>("SearchListingType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SearchMake")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SearchMaxHours")
                        .HasColumnType("int");

                    b.Property<int>("SearchMaxNumColors")
                        .HasColumnType("int");

                    b.Property<int>("SearchMaxNumDieStations")
                        .HasColumnType("int");

                    b.Property<int>("SearchMaxWidth")
                        .HasColumnType("int");

                    b.Property<int>("SearchMinHours")
                        .HasColumnType("int");

                    b.Property<int>("SearchMinNumColors")
                        .HasColumnType("int");

                    b.Property<int>("SearchMinNumDieStations")
                        .HasColumnType("int");

                    b.Property<int>("SearchMinWidth")
                        .HasColumnType("int");

                    b.Property<string>("SearchModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SearchSiteUserId")
                        .HasColumnType("int");

                    b.Property<int>("SearchToYear")
                        .HasColumnType("int");

                    b.HasKey("SearchId");

                    b.ToTable("Searches");
                });

            modelBuilder.Entity("NarrowWebExchangeProj.Models.SiteUser", b =>
                {
                    b.Property<int>("SiteUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SiteUserCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteUserFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteUserLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteUserPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteUserState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteUserStreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteUserZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SiteUserId");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("SiteUsers");
                });

            modelBuilder.Entity("NarrowWebExchangeProj.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StateAbbreviation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateId");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            StateId = 1,
                            StateAbbreviation = "AL",
                            StateName = "Alabama"
                        },
                        new
                        {
                            StateId = 2,
                            StateAbbreviation = "AK",
                            StateName = "Alaska"
                        },
                        new
                        {
                            StateId = 3,
                            StateAbbreviation = "AZ",
                            StateName = "Arizona"
                        },
                        new
                        {
                            StateId = 4,
                            StateAbbreviation = "AR",
                            StateName = "Arkansas"
                        },
                        new
                        {
                            StateId = 5,
                            StateAbbreviation = "CA",
                            StateName = "California"
                        },
                        new
                        {
                            StateId = 6,
                            StateAbbreviation = "CO",
                            StateName = "Colorado"
                        },
                        new
                        {
                            StateId = 7,
                            StateAbbreviation = "CT",
                            StateName = "Connecticut"
                        },
                        new
                        {
                            StateId = 8,
                            StateAbbreviation = "DE",
                            StateName = "Delaware"
                        },
                        new
                        {
                            StateId = 9,
                            StateAbbreviation = "FL",
                            StateName = "Florida"
                        },
                        new
                        {
                            StateId = 10,
                            StateAbbreviation = "GA",
                            StateName = "Georgia"
                        },
                        new
                        {
                            StateId = 11,
                            StateAbbreviation = "HI",
                            StateName = "Hawaii"
                        },
                        new
                        {
                            StateId = 12,
                            StateAbbreviation = "ID",
                            StateName = "Idaho"
                        },
                        new
                        {
                            StateId = 13,
                            StateAbbreviation = "IL",
                            StateName = "Illinois"
                        },
                        new
                        {
                            StateId = 14,
                            StateAbbreviation = "IN",
                            StateName = "Indiana"
                        },
                        new
                        {
                            StateId = 15,
                            StateAbbreviation = "IA",
                            StateName = "Iowa"
                        },
                        new
                        {
                            StateId = 16,
                            StateAbbreviation = "KS",
                            StateName = "Kansas"
                        },
                        new
                        {
                            StateId = 17,
                            StateAbbreviation = "KY",
                            StateName = "Kentucky"
                        },
                        new
                        {
                            StateId = 18,
                            StateAbbreviation = "LA",
                            StateName = "Louisiana"
                        },
                        new
                        {
                            StateId = 19,
                            StateAbbreviation = "ME",
                            StateName = "Maine"
                        },
                        new
                        {
                            StateId = 20,
                            StateAbbreviation = "MD",
                            StateName = "Maryland"
                        },
                        new
                        {
                            StateId = 21,
                            StateAbbreviation = "MA",
                            StateName = "Massachusetts"
                        },
                        new
                        {
                            StateId = 22,
                            StateAbbreviation = "MI",
                            StateName = "Michigan"
                        },
                        new
                        {
                            StateId = 23,
                            StateAbbreviation = "MN",
                            StateName = "Minnesota"
                        },
                        new
                        {
                            StateId = 24,
                            StateAbbreviation = "MS",
                            StateName = "Mississippi"
                        },
                        new
                        {
                            StateId = 25,
                            StateAbbreviation = "MO",
                            StateName = "Missouri"
                        },
                        new
                        {
                            StateId = 26,
                            StateAbbreviation = "MT",
                            StateName = "Montana"
                        },
                        new
                        {
                            StateId = 27,
                            StateAbbreviation = "NE",
                            StateName = "Nebraska"
                        },
                        new
                        {
                            StateId = 28,
                            StateAbbreviation = "NV",
                            StateName = "Nevada"
                        },
                        new
                        {
                            StateId = 29,
                            StateAbbreviation = "NH",
                            StateName = "New Hampshire"
                        },
                        new
                        {
                            StateId = 30,
                            StateAbbreviation = "NJ",
                            StateName = "New Jersey"
                        },
                        new
                        {
                            StateId = 31,
                            StateAbbreviation = "NM",
                            StateName = "New Mexico"
                        },
                        new
                        {
                            StateId = 32,
                            StateAbbreviation = "NY",
                            StateName = "New York"
                        },
                        new
                        {
                            StateId = 33,
                            StateAbbreviation = "NC",
                            StateName = "North Carolina"
                        },
                        new
                        {
                            StateId = 34,
                            StateAbbreviation = "ND",
                            StateName = "North Dakota"
                        },
                        new
                        {
                            StateId = 35,
                            StateAbbreviation = "OH",
                            StateName = "Ohio"
                        },
                        new
                        {
                            StateId = 36,
                            StateAbbreviation = "OK",
                            StateName = "Oklahoma"
                        },
                        new
                        {
                            StateId = 37,
                            StateAbbreviation = "OR",
                            StateName = "Oregon"
                        },
                        new
                        {
                            StateId = 38,
                            StateAbbreviation = "PA",
                            StateName = "Pennsylvania"
                        },
                        new
                        {
                            StateId = 39,
                            StateAbbreviation = "RI",
                            StateName = "Rhode Island"
                        },
                        new
                        {
                            StateId = 40,
                            StateAbbreviation = "SC",
                            StateName = "South Carolina"
                        },
                        new
                        {
                            StateId = 41,
                            StateAbbreviation = "SD",
                            StateName = "South Dakota"
                        },
                        new
                        {
                            StateId = 42,
                            StateAbbreviation = "TN",
                            StateName = "Tennessee"
                        },
                        new
                        {
                            StateId = 43,
                            StateAbbreviation = "TX",
                            StateName = "Texas"
                        },
                        new
                        {
                            StateId = 44,
                            StateAbbreviation = "UT",
                            StateName = "Utah"
                        },
                        new
                        {
                            StateId = 45,
                            StateAbbreviation = "VT",
                            StateName = "Vermont"
                        },
                        new
                        {
                            StateId = 46,
                            StateAbbreviation = "VA",
                            StateName = "Virginia"
                        },
                        new
                        {
                            StateId = 47,
                            StateAbbreviation = "WA",
                            StateName = "Washington"
                        },
                        new
                        {
                            StateId = 48,
                            StateAbbreviation = "WV",
                            StateName = "West Virginia"
                        },
                        new
                        {
                            StateId = 49,
                            StateAbbreviation = "WI",
                            StateName = "Wisconsin"
                        },
                        new
                        {
                            StateId = 50,
                            StateAbbreviation = "WY",
                            StateName = "Wyoming"
                        },
                        new
                        {
                            StateId = 51,
                            StateAbbreviation = "DC",
                            StateName = "District of Columbia"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NarrowWebExchangeProj.Models.Listing", b =>
                {
                    b.HasOne("NarrowWebExchangeProj.Models.SiteUser", "UserId")
                        .WithMany()
                        .HasForeignKey("UserIdSiteUserId");
                });

            modelBuilder.Entity("NarrowWebExchangeProj.Models.SiteUser", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
