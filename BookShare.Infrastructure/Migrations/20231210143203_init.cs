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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LocationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BooksForSale",
                columns: table => new
                {
                    BookForSaleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<int>(type: "int", nullable: false),
                    BookCategory = table.Column<int>(type: "int", nullable: false),
                    Subject1 = table.Column<int>(type: "int", nullable: false),
                    MarketPrice = table.Column<decimal>(type: "money", nullable: false),
                    SellingPrice = table.Column<decimal>(type: "money", nullable: true),
                    ListedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookCondition = table.Column<int>(type: "int", nullable: false),
                    IsSoldOut = table.Column<bool>(type: "bit", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDisabled = table.Column<bool>(type: "bit", nullable: true),
                    HarmfulContentCount = table.Column<byte>(type: "tinyint", nullable: true),
                    ListingType = table.Column<int>(type: "int", nullable: false),
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
                    { "42946241-268b-4f1f-9ab4-a6fd6357ea8e", null, "Transporter", "TRANSPORTER" },
                    { "55e46840-6af0-4c2f-b380-534640cd70a0", null, "Admin", "ADMIN" },
                    { "8517e139-85d0-4eb9-baf5-4dd3e96e9961", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "IsVerified", "KycId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName", "UserType" },
                values: new object[,]
                {
                    { "69894d68-4f61-4a49-b884-ff1dcc50e917", 0, "22fcef9a-26f8-4424-bec5-5be7b2fa0416", "pwalesby2@addthis.com", true, "Pyotr", "https://thumbs.dreamstime.com/z/attractive-serious-african-american-lady-6620517.jpg", false, null, "Walesby", false, null, null, null, null, null, false, "6123680a-1edd-4e65-a90d-724ed3ee556f", false, "e62dfff9-e41d-426c-acda-f0638d5d9d5b", null, 2 },
                    { "b0c6aaed-43ec-4364-b8c7-f6368ac1f34f", 0, "d3a242ad-ad77-449d-afa8-99ae12322a9b", "ddunphie0@amazon.com", true, "Doretta", "https://thumbs.dreamstime.com/z/attractive-serious-african-american-lady-6620517.jpg", false, null, "Dunphie", false, null, null, null, null, null, false, "e4a99c3c-e994-468e-af38-8948c1f929fc", false, "25d73632-0715-40df-aec6-e4833dacdca6", null, 2 },
                    { "d7b17747-3e99-410c-8d4a-e3b2b9fc05b3", 0, "64c1bb84-6c58-4bf8-82ab-bd3578486393", "cmounch1@behance.net", true, "Chane", "https://images.pexels.com/photos/2379004/pexels-photo-2379004.jpeg", false, null, "Mounch", false, null, null, null, null, null, false, "69a61ca6-fe2c-4b94-b2f4-04790864ef2c", false, "b017365a-2f2d-463d-8707-66a9b590839a", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "BooksForSale",
                columns: new[] { "BookForSaleId", "Author", "BookCategory", "BookCondition", "BookDescription", "BookName", "DateAdded", "DateModified", "Subject", "HarmfulContentCount", "ISBN", "ImageUrl", "IsDeleted", "IsDisabled", "IsSoldOut", "ListedDate", "ListingType", "LocationId", "MarketPrice", "Publisher", "RequestId", "SellingPrice", "Subject1", "UserId" },
                values: new object[,]
                {
                    { "0bb6a6f4-d16a-4fbf-bf23-926b4987ff7a", "Robert Miller", 1, 2, "Business studies textbook", "Introduction to Business Studies", new DateTime(2023, 12, 10, 15, 32, 3, 574, DateTimeKind.Utc).AddTicks(9333), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, (byte)3, "978-3-456-78901-2", null, false, true, false, new DateTime(2023, 12, 10, 14, 32, 3, 574, DateTimeKind.Utc).AddTicks(9339), 1, null, 34.99m, null, null, 24.99m, 10, null },
                    { "1b55e794-02ce-48c4-b2a1-49770e97c158", "Emily White", 0, 0, "Introduction to chemistry", "Chemistry Basics", new DateTime(2023, 12, 10, 15, 32, 3, 574, DateTimeKind.Utc).AddTicks(9348), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "978-4-567-89012-3", null, false, null, false, new DateTime(2023, 12, 10, 14, 32, 3, 574, DateTimeKind.Utc).AddTicks(9353), 0, null, 27.99m, null, null, 17.99m, 6, null },
                    { "25a9cfcc-24c3-4fe4-83ef-6f82e8704b4e", "John Doe", 0, 3, "Economics textbook", "Introduction to Economics", new DateTime(2023, 12, 10, 15, 32, 3, 574, DateTimeKind.Utc).AddTicks(9238), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "978-0-123-45678-9", null, false, true, false, new DateTime(2023, 12, 10, 14, 32, 3, 574, DateTimeKind.Utc).AddTicks(9272), 1, null, 29.99m, null, null, 19.99m, 9, null },
                    { "3b59a7f2-91a0-4991-bb2b-3ee5d779d15b", "Charlotte Williams", 4, 3, "A compilation of classic literature", "Literary Classics Collection", new DateTime(2023, 12, 10, 15, 32, 3, 574, DateTimeKind.Utc).AddTicks(9415), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "978-8-901-23456-7", null, false, null, false, new DateTime(2023, 12, 10, 14, 32, 3, 574, DateTimeKind.Utc).AddTicks(9419), 1, null, 54.99m, null, null, 44.99m, 13, null },
                    { "3fcd4fe1-d8b7-4f9a-8625-8c92c8317409", "John Doe", 0, 1, "Physics textbook for beginners", "Introduction to Physics", new DateTime(2023, 12, 10, 15, 32, 3, 574, DateTimeKind.Utc).AddTicks(9305), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, (byte)4, "978-1-234-56789-0", null, false, null, false, new DateTime(2023, 12, 10, 14, 32, 3, 574, DateTimeKind.Utc).AddTicks(9310), 1, null, 49.99m, null, null, 39.99m, 5, null },
                    { "5f1c6d9a-3e85-46b0-b7c4-1e7df41e084e", "Ryan Mitchell", 1, 1, "Understanding ethical business practices", "Business Ethics", new DateTime(2023, 12, 10, 15, 32, 3, 574, DateTimeKind.Utc).AddTicks(9451), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, "978-3-333-44444-4", null, false, null, false, new DateTime(2023, 12, 10, 14, 32, 3, 574, DateTimeKind.Utc).AddTicks(9455), 1, null, 39.99m, null, null, 29.99m, 10, null },
                    { "6e7e78a5-2b1e-4a71-b1a2-5b35bf7e7c2c", "Michael Brown", 3, 1, "Introduction to computer science", "Computer Science Fundamentals", new DateTime(2023, 12, 10, 15, 32, 3, 574, DateTimeKind.Utc).AddTicks(9361), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "978-5-678-90123-4", null, false, null, false, new DateTime(2023, 12, 10, 14, 32, 3, 574, DateTimeKind.Utc).AddTicks(9366), 0, null, 39.99m, null, null, 29.99m, 11, null },
                    { "735bf9c0-947a-4b29-b3c4-0e8eab31c34b", "Daniel Turner", 0, 0, "Fundamental concepts of physics", "Physics for Beginners", new DateTime(2023, 12, 10, 15, 32, 3, 574, DateTimeKind.Utc).AddTicks(9427), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "978-9-012-34567-8", null, false, null, false, new DateTime(2023, 12, 10, 14, 32, 3, 574, DateTimeKind.Utc).AddTicks(9431), 1, null, 29.99m, null, null, 19.99m, 5, null },
                    { "7e6e1b1d-7d91-45d7-a9d4-0e953ab12c3a", "Olivia Davis", 2, 2, "Discovering the world of art", "Art Appreciation", new DateTime(2023, 12, 10, 15, 32, 3, 574, DateTimeKind.Utc).AddTicks(9439), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "978-0-111-22222-2", null, false, null, false, new DateTime(2023, 12, 10, 14, 32, 3, 574, DateTimeKind.Utc).AddTicks(9443), 0, null, 34.99m, null, null, 24.99m, 16, null },
                    { "8eaa6d2b-e4cc-4c48-9205-8ef9f2c2c5b8", "Emma Turner", 0, 2, "Exploring the environment and ecosystems", "Environmental Science", new DateTime(2023, 12, 10, 15, 32, 3, 574, DateTimeKind.Utc).AddTicks(9463), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "978-5-555-66666-6", null, false, null, false, new DateTime(2023, 12, 10, 14, 32, 3, 574, DateTimeKind.Utc).AddTicks(9467), 0, null, 49.99m, null, null, 39.99m, 1, null },
                    { "8eb4f536-7680-4a77-9f84-3c6ac75c77d2", "Jane Smith", 1, 2, "Macroeconomics textbook", "Macroeconomics Explained", new DateTime(2023, 12, 10, 15, 32, 3, 574, DateTimeKind.Utc).AddTicks(9286), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, (byte)5, "978-0-987-65432-1", null, false, null, false, new DateTime(2023, 12, 10, 14, 32, 3, 574, DateTimeKind.Utc).AddTicks(9291), 0, null, 39.99m, null, null, 29.99m, 9, null },
                    { "9a1d8c0a-b7c4-43aa-89a2-9109d77477db", "David Thompson", 4, 2, "Exploring historical events", "History Uncovered", new DateTime(2023, 12, 10, 15, 32, 3, 574, DateTimeKind.Utc).AddTicks(9389), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, "978-6-789-01234-5", null, false, null, false, new DateTime(2023, 12, 10, 14, 32, 3, 574, DateTimeKind.Utc).AddTicks(9393), 1, null, 44.99m, null, null, 34.99m, 4, null },
                    { "b3268c1b-04d0-4d07-b393-853e228f5aaf", "Sophie Clark", 0, 1, "Fun math problems for enthusiasts", "Math Puzzles and Challenges", new DateTime(2023, 12, 10, 15, 32, 3, 574, DateTimeKind.Utc).AddTicks(9402), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "978-7-890-12345-6", null, false, null, false, new DateTime(2023, 12, 10, 14, 32, 3, 574, DateTimeKind.Utc).AddTicks(9406), 0, null, 19.99m, null, null, 9.99m, 0, null },
                    { "d450b2f3-4d20-4d22-8d4e-4e6ef3a429b3", "Sophia Johnson", 4, 3, "Introduction to philosophical concepts", "Philosophy Fundamentals", new DateTime(2023, 12, 10, 15, 32, 3, 574, DateTimeKind.Utc).AddTicks(9474), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "978-6-666-77777-7", null, false, null, false, new DateTime(2023, 12, 10, 14, 32, 3, 574, DateTimeKind.Utc).AddTicks(9479), 1, null, 24.99m, null, null, 14.99m, 2, null },
                    { "fd6726e7-0dbb-4e4c-bc29-4cd4c6e8ecf7", "Alice Johnson", 4, 3, "Grammar guide for language learners", "English Grammar Essentials", new DateTime(2023, 12, 10, 15, 32, 3, 574, DateTimeKind.Utc).AddTicks(9319), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, (byte)5, "978-2-345-67890-1", null, false, true, false, new DateTime(2023, 12, 10, 14, 32, 3, 574, DateTimeKind.Utc).AddTicks(9324), 1, null, 29.99m, null, null, 19.99m, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Transporters",
                columns: new[] { "UserId", "CompanyName", "DateAdded", "DateModified", "DocumentType", "IsDeleted", "LocationId", "LogoUrl", "PhoneNumber" },
                values: new object[,]
                {
                    { "25d73632-0715-40df-aec6-e4833dacdca6", "Doretta and Company", new DateTime(2023, 12, 10, 15, 32, 3, 575, DateTimeKind.Utc).AddTicks(7289), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, "https://cdn.dribbble.com/userupload/4706150/file/original-637a80baa0d74e38e81a889b589b4761.jpg", "09044553323" },
                    { "b017365a-2f2d-463d-8707-66a9b590839a", "On The Move Inc", new DateTime(2023, 12, 10, 15, 32, 3, 575, DateTimeKind.Utc).AddTicks(7363), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, "https://cdn.dribbble.com/userupload/4706150/file/original-637a80baa0d74e38e81a889b589b4761.jpg", "09056653323" },
                    { "e62dfff9-e41d-426c-acda-f0638d5d9d5b", "On The Move Inc", new DateTime(2023, 12, 10, 15, 32, 3, 575, DateTimeKind.Utc).AddTicks(7376), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, "https://cdn.dribbble.com/userupload/4706150/file/original-637a80baa0d74e38e81a889b589b4761.jpg", "09056653323" }
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
