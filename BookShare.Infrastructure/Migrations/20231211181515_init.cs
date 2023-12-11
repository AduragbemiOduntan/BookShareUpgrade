using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KYCs",
                columns: table => new
                {
                    KycId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateIssued = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KYCs", x => x.KycId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LGA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    KycId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_KYCs_KycId",
                        column: x => x.KycId,
                        principalTable: "KYCs",
                        principalColumn: "KycId");
                });

            migrationBuilder.CreateTable(
                name: "Transporters",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transporters", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Transporters_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Requests",
                columns: table => new
                {
                    RequestId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsReceived = table.Column<bool>(type: "bit", nullable: false),
                    IsDelivered = table.Column<bool>(type: "bit", nullable: false),
                    IsPickUp = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LocationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_Requests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId");
                });

            migrationBuilder.CreateTable(
                name: "BooksForSale",
                columns: table => new
                {
                    BookForSaleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookCreationId = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookCategory = table.Column<int>(type: "int", nullable: true),
                    MarketPrice = table.Column<decimal>(type: "money", nullable: false),
                    SellingPrice = table.Column<decimal>(type: "money", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListingType = table.Column<int>(type: "int", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<int>(type: "int", nullable: true),
                    Subject1 = table.Column<int>(type: "int", nullable: true),
                    ListedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookCondition = table.Column<int>(type: "int", nullable: true),
                    IsSoldOut = table.Column<bool>(type: "bit", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDisabled = table.Column<bool>(type: "bit", nullable: true),
                    HarmfulContentCount = table.Column<byte>(type: "tinyint", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LocationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RequestId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksForSale", x => x.BookForSaleId);
                    table.ForeignKey(
                        name: "FK_BooksForSale_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BooksForSale_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId");
                    table.ForeignKey(
                        name: "FK_BooksForSale_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "RequestId");
                });

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    DeliveryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RecipientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryPrice = table.Column<decimal>(type: "money", nullable: false),
                    ReceiverPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelivered = table.Column<bool>(type: "bit", nullable: false),
                    LocationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TransporterId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookForSaleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RequestId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.DeliveryId);
                    table.ForeignKey(
                        name: "FK_Deliveries_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deliveries_BooksForSale_BookForSaleId",
                        column: x => x.BookForSaleId,
                        principalTable: "BooksForSale",
                        principalColumn: "BookForSaleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deliveries_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deliveries_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "RequestId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deliveries_Transporters_TransporterId",
                        column: x => x.TransporterId,
                        principalTable: "Transporters",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0744f15b-d768-4036-897d-8e882da6cb84", null, "User", "USER" },
                    { "48b9386e-57bc-4ebe-85c5-2caedb027917", null, "Admin", "ADMIN" },
                    { "c93916f8-51f0-4c01-8bd3-91d5106b8ee4", null, "Transporter", "TRANSPORTER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "IsVerified", "KycId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName", "UserType" },
                values: new object[,]
                {
                    { "42de63a1-20c0-4cee-a1e9-7bbf2ff776b7", 0, "bfce7ff7-08e8-4606-9949-beb4f8b4b20b", "pwalesby2@addthis.com", true, "Pyotr", "https://thumbs.dreamstime.com/z/attractive-serious-african-american-lady-6620517.jpg", false, null, "Walesby", false, null, null, null, null, null, false, "3864c8ac-f223-4ddf-8f9b-db5aa961f9a1", false, "e62dfff9-e41d-426c-acda-f0638d5d9d5b", null, 2 },
                    { "9641de2e-08e2-4ec7-90eb-12437cdf55ee", 0, "5f876bed-9416-4c59-9e30-264eb9787776", "cmounch1@behance.net", true, "Chane", "https://images.pexels.com/photos/2379004/pexels-photo-2379004.jpeg", false, null, "Mounch", false, null, null, null, null, null, false, "62b23023-d7df-4d69-8c56-9e17c737df6e", false, "b017365a-2f2d-463d-8707-66a9b590839a", null, 2 },
                    { "c97fbb73-1edf-4aae-a367-b0521b9b4ac3", 0, "8936119f-1962-4b0a-bf21-074ad163dbdd", "ddunphie0@amazon.com", true, "Doretta", "https://thumbs.dreamstime.com/z/attractive-serious-african-american-lady-6620517.jpg", false, null, "Dunphie", false, null, null, null, null, null, false, "b072ba56-bc77-4246-8a72-01d02cb091a8", false, "25d73632-0715-40df-aec6-e4833dacdca6", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "BooksForSale",
                columns: new[] { "BookForSaleId", "Author", "BookCategory", "BookCondition", "BookCreationId", "BookDescription", "BookName", "DateAdded", "DateModified", "Subject", "HarmfulContentCount", "ISBN", "ImageUrl", "IsDeleted", "IsDisabled", "IsSoldOut", "ListedDate", "ListingType", "LocationId", "MarketPrice", "Publisher", "RequestId", "SellingPrice", "Subject1", "UserId" },
                values: new object[,]
                {
                    { "0f8b75ef-5795-4f04-843a-7feae7661f01", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6845), "Exploring innovative approaches to development in various fields.", "Journal of Development and Innovation", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6846), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/Z6zLqwD", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6845), 0, null, 3999.99m, null, null, 0.00m, null, null },
                    { "1a4ee5f0-0eab-4fe5-97e3-b0485c17384a", null, 1, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6735), "Embark on a captivating exploration of general educational studies, where the ladder to success is built with knowledge, insights, and a comprehensive understanding of key concepts.", "Laddering Your Success", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6736), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/NZstpRt", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6736), 0, null, 3999.99m, null, null, 0.00m, null, null },
                    { "1cfc1884-2aae-4ac1-97c5-27f408f140f3", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6634), "Comprehensive physics guide for SSCE and UTME exams.", "SSCE and UTME Physics", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6635), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/NTMt2Sv", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6635), 0, null, 3999.99m, null, null, 0.00m, null, null },
                    { "2f19959b-458f-42f8-927d-45ad1d66a2d8", null, 1, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6702), "Step into the intriguing world of education, where societal norms and disparities come to light, shaping the experiences of learners from different walks of life.", "How the Other Half Learns", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6703), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/mvpjYLb", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6703), 1, null, 2999.99m, null, null, 1499.99m, null, null },
                    { "3b1cc8f3-69e2-4ec0-8522-2c4e01b529c2", null, 1, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6717), "Dive into a thought-provoking narrative that envisions the future of education, its transformative power, and the impact it leaves on the last generation of graduates in a changing world.", "The Last Graduate", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6718), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/tKhXZVh", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6717), 0, null, 3999.99m, null, null, 0.00m, null, null },
                    { "418f2b38-ae9e-49a8-9a8d-2ee99c8355cc", null, 1, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6675), "A heartwarming novel that unfolds the transformative impact of a dedicated teacher on the lives of students, inspiring them to overcome challenges and achieve greatness.", "Because of a Teacher", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6676), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/NTWqctd", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6675), 1, null, 9000.00m, null, null, 4000.00m, null, null },
                    { "4b2c2c2c-3888-4214-9a3a-fa3075b9a373", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6829), "Exploring the profound impact of global historical events on society.", "Impact", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6830), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/WvtS13k", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6829), 1, null, 2999.99m, null, null, 1499.99m, null, null },
                    { "4f33e4a3-2cb2-4ef9-9839-862fc58f64cd", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6804), "Understanding business concepts and strategies for enhancing international student employability.", "International Student Employability", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6805), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/s2pTv7W", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6805), 1, null, 9000.00m, null, null, 4000.00m, null, null },
                    { "55f7d2a7-3b49-4e87-88c0-6c88e2a0e17c", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6650), "Comprehensive guide to general mathematical concepts.", "New General Mathematics", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6651), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/6RkfmFB", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6651), 0, null, 3999.99m, null, null, 0.00m, null, null },
                    { "5f68d2e2-7ce6-4310-bd29-9a46e5b60949", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6852), "In-depth study of science and technology principles.", "Research in Science and Technological Education", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6854), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/DWT5wQm", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6853), 0, null, 4499.99m, null, null, 0.00m, null, null },
                    { "64a4c5a1-7782-4b4e-90b2-704dcd9d8d24", null, 1, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6694), "Experience the gripping narrative of a group of stranded boys on a deserted island, as they grapple with power dynamics, morality, and the primal instincts that emerge in their struggle for survival.", "Lord of the Flies", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6696), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/NTPFxRr", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6695), 1, null, 5999.99m, null, null, 2999.99m, null, null },
                    { "6e6de32d-0682-4f5a-96d4-96c2f77f8f98", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6864), "Comprehensive guide to general educational studies and their concepts.", "Educational Studies", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6865), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/8YQLsfx", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6865), 0, null, 3999.99m, null, null, 0.00m, null, null },
                    { "7e4ed35f-e1a5-4a2a-baad-b6a6a2a8b5bb", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6812), "An insightful journal exploring the intersection of business and education.", "Business Education Journal", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6813), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/wKk93Fq", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6812), 1, null, 2499.99m, null, null, 1299.99m, null, null },
                    { "878a3464-58b1-49b4-bdc3-ea201b6ac6ae", null, 1, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6710), "Embark on a literary journey that explores the intricacies of personal and academic growth, as characters navigate the challenges of self-discovery within the realm of education.", "My Education", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6711), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/TgzzWF3", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6711), 0, null, 3499.99m, null, null, 0.00m, null, null },
                    { "90a1eb50-5e54-41b2-b5b9-5d3d25f7e031", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6587), "A beginner-friendly guide to computer programming.", "Computer Programming for Beginners", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6589), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/Q6XsX4J", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6588), 1, null, 5999.99m, null, null, 2999.99m, null, null },
                    { "9b03f725-521f-4a90-9f4a-7c5b89c2465c", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6579), "An engaging collection of literary masterpieces.", "Literature", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6580), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/WVzW49p", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6580), 1, null, 2499.99m, null, null, 1299.99m, null, null },
                    { "a39b8e55-7a88-4912-9d08-45b33c550a6e", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6642), "In-depth study of organic chemistry principles and reactions.", "Organic Chemistry", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6644), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/ncsvd1j", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6643), 0, null, 4499.99m, null, null, 0.00m, null, null },
                    { "a5454a2a-6e34-4a35-8e54-8789ee849c4b", null, 1, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6686), "Immerse yourself in a captivating tale that explores the birth of innovators, tracing their journeys through challenges, creativity, and the relentless pursuit of groundbreaking ideas.", "Creating Innovators", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6687), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/PQTcDJv", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6687), 1, null, 2499.99m, null, null, 1299.99m, null, null },
                    { "aa12e4eb-40a8-4cd8-837d-3dd207f56b97", null, 1, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6726), "Experience the enchanting tale of a journey through science and technology, where small yet impactful teaching methods lead to profound discoveries and innovations.", "Small Teaching", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6727), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/1XQJC2M", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6727), 0, null, 4499.99m, null, null, 0.00m, null, null },
                    { "b79b1c76-1fb0-4a44-a758-0b6e524f245b", null, 1, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6743), "Delve into the enthralling narrative of academic disciplines intersecting within the realm of education, symbolized by the reflective 'Mirror' and the illuminating 'Lamp' guiding the way.", "The Mirror and the Lamp", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6744), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/vz6pGWg", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6744), 0, null, 3499.99m, null, null, 0.00m, null, null },
                    { "b946508d-6a67-4f2e-93b0-2f1d15cb482e\r\n", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6460), "Comprehensive introduction to economic theories and principles.", "An Introduction to Economics", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6479), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/qsTTbGv", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6476), 1, null, 8000.00m, null, null, 2000.00m, null, null },
                    { "c45330b1-d6b3-4a7a-8f92-4f33a11b3195", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6872), "Explore the dynamic intersection of various academic disciplines within the realm of education.", "Journal of Interdisciplinary Studies in Education", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6874), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/SmJkzYp", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6873), 0, null, 3499.99m, null, null, 0.00m, null, null },
                    { "c93cf864-d273-44d2-98b3-b36138de7b9b", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6625), "Practical insights and experiments in the field of chemistry.", "Master Practical Chemistry", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6627), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/qDDskmB", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6626), 0, null, 3499.99m, null, null, 0.00m, null, null },
                    { "d0cde2d1-e9f7-4b1a-8a84-04ee55fb4a7e", null, 2, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6796), "A collection of short articles designed to enhance reading comprehension skills.", "Short Articles for Reading Comprehension", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6797), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/x35LZ3s", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6797), 1, null, 8000.00m, null, null, 2000.00m, null, null },
                    { "d764f82c-e4e1-4e50-825e-54c8b8b8eeb1", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6658), "Physics textbook designed for modern school curricula.", "New School Physics", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6659), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/QFmGNjR", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6659), 0, null, 3499.99m, null, null, 0.00m, null, null },
                    { "e40bb26b-6f9b-4a53-b8dd-0c1cfb9daee2", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6616), "Exploring the rich tapestry of global historical events.", "World History", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6618), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/ZhBXwtS", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6617), 1, null, 2999.99m, null, null, 1499.99m, null, null },
                    { "e4d9c0b1-7c6c-4eb1-9f5d-7c0195d2bf88", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6837), "Mastering essential words to enhance vocabulary and language skills.", "504 Absolutely Essential Words", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6838), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/PFMYxSn", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6838), 0, null, 3499.99m, null, null, 0.00m, null, null },
                    { "f1af480b-44a0-48d1-a20d-d2e1b3bd46d4", null, 1, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6667), "Embark on a riveting journey through the intricate interplay of democracy and education, where societal ideals clash and harmonize.", "Democracy and Education", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6668), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/7Vb2yM0", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6668), 1, null, 8000.00m, null, null, 2000.00m, null, null },
                    { "f78b929f-71cc-4fb2-b0d8-3188194c73f3", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6820), "A guide to navigating online teaching and learning challenges during the Covid-19 pandemic.", "Online Teaching and Learning in Higher Education during Covid-19", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6822), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/N97d49F", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6821), 1, null, 5999.99m, null, null, 2999.99m, null, null },
                    { "f7c8e0ae-3fb7-4e49-a42d-59b40698665a", null, 0, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6570), "In-depth exploration of business concepts and strategies.", "Business Studies", new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Utc).AddTicks(6572), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/m45tnVm", false, null, null, new DateTime(2023, 12, 11, 19, 15, 15, 505, DateTimeKind.Local).AddTicks(6571), 1, null, 9000.00m, null, null, 4000.00m, null, null }
                });

            migrationBuilder.InsertData(
                table: "Transporters",
                columns: new[] { "UserId", "CompanyName", "DateAdded", "DateModified", "DocumentType", "IsDeleted", "LocationId", "LogoUrl", "PhoneNumber" },
                values: new object[,]
                {
                    { "25d73632-0715-40df-aec6-e4833dacdca6", "Doretta and Company", new DateTime(2023, 12, 11, 19, 15, 15, 506, DateTimeKind.Utc).AddTicks(2966), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, "https://cdn.dribbble.com/userupload/4706150/file/original-637a80baa0d74e38e81a889b589b4761.jpg", "09044553323" },
                    { "b017365a-2f2d-463d-8707-66a9b590839a", "On The Move Inc", new DateTime(2023, 12, 11, 19, 15, 15, 506, DateTimeKind.Utc).AddTicks(3023), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, "https://cdn.dribbble.com/userupload/4706150/file/original-637a80baa0d74e38e81a889b589b4761.jpg", "09056653323" },
                    { "e62dfff9-e41d-426c-acda-f0638d5d9d5b", "On The Move Inc", new DateTime(2023, 12, 11, 19, 15, 15, 506, DateTimeKind.Utc).AddTicks(3031), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, "https://cdn.dribbble.com/userupload/4706150/file/original-637a80baa0d74e38e81a889b589b4761.jpg", "09056653323" }
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
                name: "IX_AspNetUsers_KycId",
                table: "AspNetUsers",
                column: "KycId",
                unique: true,
                filter: "[KycId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BooksForSale_LocationId",
                table: "BooksForSale",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksForSale_RequestId",
                table: "BooksForSale",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksForSale_UserId",
                table: "BooksForSale",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_BookForSaleId",
                table: "Deliveries",
                column: "BookForSaleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_LocationId",
                table: "Deliveries",
                column: "LocationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_RequestId",
                table: "Deliveries",
                column: "RequestId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_TransporterId",
                table: "Deliveries",
                column: "TransporterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_UserId",
                table: "Deliveries",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_LocationId",
                table: "Requests",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_UserId",
                table: "Requests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transporters_LocationId",
                table: "Transporters",
                column: "LocationId");
        }

        /// <inheritdoc />
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
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "BooksForSale");

            migrationBuilder.DropTable(
                name: "Transporters");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "KYCs");
        }
    }
}
