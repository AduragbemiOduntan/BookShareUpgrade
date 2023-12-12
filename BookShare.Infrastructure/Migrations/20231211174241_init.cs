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
                    { "34e6cb6f-0188-4ec7-b48a-4aa205e6d329", null, "Transporter", "TRANSPORTER" },
                    { "52175491-4110-47fa-9974-14f2d4e97142", null, "Admin", "ADMIN" },
                    { "f244cd5c-88a2-4309-b98a-753be45813a8", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "IsVerified", "KycId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName", "UserType" },
                values: new object[,]
                {
                    { "3d379766-125b-4f35-96ef-d395fd1a5dc2", 0, "f7c83f7a-92cd-4632-9a8a-90e38948772a", "ddunphie0@amazon.com", true, "Doretta", "https://thumbs.dreamstime.com/z/attractive-serious-african-american-lady-6620517.jpg", false, null, "Dunphie", false, null, null, null, null, null, false, "135265ca-7c03-4425-8737-8719eac5a1cf", false, "25d73632-0715-40df-aec6-e4833dacdca6", null, 2 },
                    { "bf6238b7-9c1f-4555-96c9-214526b75f82", 0, "6fed2e80-8318-4d7b-8f34-982bab93c6d3", "cmounch1@behance.net", true, "Chane", "https://images.pexels.com/photos/2379004/pexels-photo-2379004.jpeg", false, null, "Mounch", false, null, null, null, null, null, false, "f82c54ba-6ef4-416e-ae98-0e59c57d259b", false, "b017365a-2f2d-463d-8707-66a9b590839a", null, 2 },
                    { "c936bf3d-992c-42f4-b05f-a4a57920dada", 0, "b0cdc435-9e88-43c0-923d-257090a4e4f6", "pwalesby2@addthis.com", true, "Pyotr", "https://thumbs.dreamstime.com/z/attractive-serious-african-american-lady-6620517.jpg", false, null, "Walesby", false, null, null, null, null, null, false, "a29d457f-4dd0-4ce5-b30e-09331ab26e5f", false, "e62dfff9-e41d-426c-acda-f0638d5d9d5b", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "BooksForSale",
                columns: new[] { "BookForSaleId", "Author", "BookCategory", "BookCondition", "BookCreationId", "BookDescription", "BookName", "DateAdded", "DateModified", "Subject", "HarmfulContentCount", "ISBN", "ImageUrl", "IsDeleted", "IsDisabled", "IsSoldOut", "ListedDate", "ListingType", "LocationId", "MarketPrice", "Publisher", "RequestId", "SellingPrice", "Subject1", "UserId" },
                values: new object[,]
                {
                    { "0f8b75ef-5795-4f04-843a-7feae7661f01", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1662), "Exploring innovative approaches to development in various fields.", "Journal of Development and Innovation", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1664), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/Z6zLqwD", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1663), null, null, 3999.99m, null, null, 2499.99m, null, null },
                    { "1a4ee5f0-0eab-4fe5-97e3-b0485c17384a", null, 1, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1569), "Embark on a captivating exploration of general educational studies, where the ladder to success is built with knowledge, insights, and a comprehensive understanding of key concepts.", "Laddering Your Success", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1571), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/NZstpRt", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1570), null, null, 3999.99m, null, null, 1999.99m, null, null },
                    { "1cfc1884-2aae-4ac1-97c5-27f408f140f3", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1235), "Comprehensive physics guide for SSCE and UTME exams.", "SSCE and UTME Physics", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1237), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/NTMt2Sv", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1236), null, null, 3999.99m, null, null, 2499.99m, null, null },
                    { "2f19959b-458f-42f8-927d-45ad1d66a2d8", null, 1, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1471), "Step into the intriguing world of education, where societal norms and disparities come to light, shaping the experiences of learners from different walks of life.", "How the Other Half Learns", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1507), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/mvpjYLb", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1478), null, null, 2999.99m, null, null, 1499.99m, null, null },
                    { "3b1cc8f3-69e2-4ec0-8522-2c4e01b529c2", null, 1, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1550), "Dive into a thought-provoking narrative that envisions the future of education, its transformative power, and the impact it leaves on the last generation of graduates in a changing world.", "The Last Graduate", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1552), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/tKhXZVh", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1551), null, null, 3999.99m, null, null, 2499.99m, null, null },
                    { "418f2b38-ae9e-49a8-9a8d-2ee99c8355cc", null, 1, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1437), "A heartwarming novel that unfolds the transformative impact of a dedicated teacher on the lives of students, inspiring them to overcome challenges and achieve greatness.", "Because of a Teacher", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1439), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/NTWqctd", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1438), null, null, 9000.00m, null, null, 4000.00m, null, null },
                    { "4b2c2c2c-3888-4214-9a3a-fa3075b9a373", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1641), "Exploring the profound impact of global historical events on society.", "Impact", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1643), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/WvtS13k", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1642), null, null, 2999.99m, null, null, 1499.99m, null, null },
                    { "4f33e4a3-2cb2-4ef9-9839-862fc58f64cd", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1608), "Understanding business concepts and strategies for enhancing international student employability.", "International Student Employability", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1610), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/s2pTv7W", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1609), null, null, 9000.00m, null, null, 4000.00m, null, null },
                    { "55f7d2a7-3b49-4e87-88c0-6c88e2a0e17c", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1387), "Comprehensive guide to general mathematical concepts.", "New General Mathematics", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1396), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/6RkfmFB", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1387), null, null, 3999.99m, null, null, 1999.99m, null, null },
                    { "5f68d2e2-7ce6-4310-bd29-9a46e5b60949", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1673), "In-depth study of science and technology principles.", "Research in Science and Technological Education", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1675), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/DWT5wQm", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1674), null, null, 4499.99m, null, null, 2999.99m, null, null },
                    { "64a4c5a1-7782-4b4e-90b2-704dcd9d8d24", null, 1, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1460), "Experience the gripping narrative of a group of stranded boys on a deserted island, as they grapple with power dynamics, morality, and the primal instincts that emerge in their struggle for survival.", "Lord of the Flies", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1462), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/NTPFxRr", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1461), null, null, 5999.99m, null, null, 2999.99m, null, null },
                    { "6e6de32d-0682-4f5a-96d4-96c2f77f8f98", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1688), "Comprehensive guide to general educational studies and their concepts.", "Educational Studies", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1689), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/8YQLsfx", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1688), null, null, 3999.99m, null, null, 1999.99m, null, null },
                    { "7e4ed35f-e1a5-4a2a-baad-b6a6a2a8b5bb", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1618), "An insightful journal exploring the intersection of business and education.", "Business Education Journal", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1619), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/wKk93Fq", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1619), null, null, 2499.99m, null, null, 1299.99m, null, null },
                    { "878a3464-58b1-49b4-bdc3-ea201b6ac6ae", null, 1, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1535), "Embark on a literary journey that explores the intricacies of personal and academic growth, as characters navigate the challenges of self-discovery within the realm of education.", "My Education", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1537), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/TgzzWF3", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1536), null, null, 3499.99m, null, null, 1999.99m, null, null },
                    { "90a1eb50-5e54-41b2-b5b9-5d3d25f7e031", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1203), "A beginner-friendly guide to computer programming.", "Computer Programming for Beginners", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1205), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/Q6XsX4J", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1204), null, null, 5999.99m, null, null, 2999.99m, null, null },
                    { "9b03f725-521f-4a90-9f4a-7c5b89c2465c", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1168), "An engaging collection of literary masterpieces.", "Literature", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1170), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/WVzW49p", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1169), null, null, 2499.99m, null, null, 1299.99m, null, null },
                    { "a39b8e55-7a88-4912-9d08-45b33c550a6e", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1368), "In-depth study of organic chemistry principles and reactions.", "Organic Chemistry", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1370), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/ncsvd1j", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1369), null, null, 4499.99m, null, null, 2999.99m, null, null },
                    { "a5454a2a-6e34-4a35-8e54-8789ee849c4b", null, 1, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1448), "Immerse yourself in a captivating tale that explores the birth of innovators, tracing their journeys through challenges, creativity, and the relentless pursuit of groundbreaking ideas.", "Creating Innovators", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1450), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/PQTcDJv", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1449), null, null, 2499.99m, null, null, 1299.99m, null, null },
                    { "aa12e4eb-40a8-4cd8-837d-3dd207f56b97", null, 1, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1561), "Experience the enchanting tale of a journey through science and technology, where small yet impactful teaching methods lead to profound discoveries and innovations.", "Small Teaching", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1562), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/1XQJC2M", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1561), null, null, 4499.99m, null, null, 2999.99m, null, null },
                    { "b79b1c76-1fb0-4a44-a758-0b6e524f245b", null, 1, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1587), "Delve into the enthralling narrative of academic disciplines intersecting within the realm of education, symbolized by the reflective 'Mirror' and the illuminating 'Lamp' guiding the way.", "The Mirror and the Lamp", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1589), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/vz6pGWg", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1588), null, null, 3499.99m, null, null, 1799.99m, null, null },
                    { "b946508d-6a67-4f2e-93b0-2f1d15cb482e\r\n", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1055), "Comprehensive introduction to economic theories and principles.", "An Introduction to Economics", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1099), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/qsTTbGv", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1096), null, null, 8000.00m, null, null, 2000.00m, null, null },
                    { "c45330b1-d6b3-4a7a-8f92-4f33a11b3195", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1712), "Explore the dynamic intersection of various academic disciplines within the realm of education.", "Journal of Interdisciplinary Studies in Education", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1714), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/SmJkzYp", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1713), null, null, 3499.99m, null, null, 1799.99m, null, null },
                    { "c93cf864-d273-44d2-98b3-b36138de7b9b", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1225), "Practical insights and experiments in the field of chemistry.", "Master Practical Chemistry", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1227), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/qDDskmB", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1226), null, null, 3499.99m, null, null, 1999.99m, null, null },
                    { "d0cde2d1-e9f7-4b1a-8a84-04ee55fb4a7e", null, 2, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1598), "A collection of short articles designed to enhance reading comprehension skills.", "Short Articles for Reading Comprehension", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1600), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/x35LZ3s", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1599), null, null, 8000.00m, null, null, 2000.00m, null, null },
                    { "d764f82c-e4e1-4e50-825e-54c8b8b8eeb1", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1406), "Physics textbook designed for modern school curricula.", "New School Physics", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1408), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/QFmGNjR", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1407), null, null, 3499.99m, null, null, 1799.99m, null, null },
                    { "e40bb26b-6f9b-4a53-b8dd-0c1cfb9daee2", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1214), "Exploring the rich tapestry of global historical events.", "World History", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1216), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/ZhBXwtS", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1215), null, null, 2999.99m, null, null, 1499.99m, null, null },
                    { "e4d9c0b1-7c6c-4eb1-9f5d-7c0195d2bf88", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1652), "Mastering essential words to enhance vocabulary and language skills.", "504 Absolutely Essential Words", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1654), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/PFMYxSn", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1653), null, null, 3499.99m, null, null, 1999.99m, null, null },
                    { "f1af480b-44a0-48d1-a20d-d2e1b3bd46d4", null, 1, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1417), "Embark on a riveting journey through the intricate interplay of democracy and education, where societal ideals clash and harmonize.", "Democracy and Education", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1419), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/7Vb2yM0", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1418), null, null, 8000.00m, null, null, 2000.00m, null, null },
                    { "f78b929f-71cc-4fb2-b0d8-3188194c73f3", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1627), "A guide to navigating online teaching and learning challenges during the Covid-19 pandemic.", "Online Teaching and Learning in Higher Education during Covid-19", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1628), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/N97d49F", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1628), null, null, 5999.99m, null, null, 2999.99m, null, null },
                    { "f7c8e0ae-3fb7-4e49-a42d-59b40698665a", null, 0, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1156), "In-depth exploration of business concepts and strategies.", "Business Studies", new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Utc).AddTicks(1157), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://ibb.co/m45tnVm", false, null, null, new DateTime(2023, 12, 11, 18, 42, 41, 19, DateTimeKind.Local).AddTicks(1156), null, null, 9000.00m, null, null, 4000.00m, null, null }
                });

            migrationBuilder.InsertData(
                table: "Transporters",
                columns: new[] { "UserId", "CompanyName", "DateAdded", "DateModified", "DocumentType", "IsDeleted", "LocationId", "LogoUrl", "PhoneNumber" },
                values: new object[,]
                {
                    { "25d73632-0715-40df-aec6-e4833dacdca6", "Doretta and Company", new DateTime(2023, 12, 11, 18, 42, 41, 20, DateTimeKind.Utc).AddTicks(180), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, "https://cdn.dribbble.com/userupload/4706150/file/original-637a80baa0d74e38e81a889b589b4761.jpg", "09044553323" },
                    { "b017365a-2f2d-463d-8707-66a9b590839a", "On The Move Inc", new DateTime(2023, 12, 11, 18, 42, 41, 20, DateTimeKind.Utc).AddTicks(854), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, "https://cdn.dribbble.com/userupload/4706150/file/original-637a80baa0d74e38e81a889b589b4761.jpg", "09056653323" },
                    { "e62dfff9-e41d-426c-acda-f0638d5d9d5b", "On The Move Inc", new DateTime(2023, 12, 11, 18, 42, 41, 20, DateTimeKind.Utc).AddTicks(882), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, "https://cdn.dribbble.com/userupload/4706150/file/original-637a80baa0d74e38e81a889b589b4761.jpg", "09056653323" }
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
