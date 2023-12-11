using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14f9c5ba-0a14-462d-bd31-a0f5ea7a3b5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fda14c9-bdbb-4dc8-a0aa-9772b04bebf9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b07b7e9-8a36-4c9c-98ee-9cc30306214e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "918549d8-bc16-4b1c-8c58-5a7130aed815");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b91cbc79-498a-4378-87ea-547574a0befe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9055518-042f-4edb-af4e-fb406a59888b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18affb8b-20fa-4ad8-836d-c05d65049936", null, "Transporter", "TRANSPORTER" },
                    { "417576b7-bf4e-4a6f-979d-bdf5ab0a8da9", null, "Admin", "ADMIN" },
                    { "dd74ae65-8750-4859-991f-a62517a700ba", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "IsVerified", "KycId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName", "UserType" },
                values: new object[,]
                {
                    { "0aa1e278-d70d-474d-b19a-5115a408551d", 0, "e0ee281d-8ab2-464e-8315-79f7477ce85b", "cmounch1@behance.net", true, "Chane", "https://images.pexels.com/photos/2379004/pexels-photo-2379004.jpeg", false, null, "Mounch", false, null, null, null, null, null, false, "914624ea-13e1-4db9-80f1-e3ca598f3acf", false, "b017365a-2f2d-463d-8707-66a9b590839a", null, 2 },
                    { "714b5c33-216f-4958-aa92-40ad9aa43912", 0, "d03d911b-4a50-4692-b4f6-fbdd5e71e015", "ddunphie0@amazon.com", true, "Doretta", "https://thumbs.dreamstime.com/z/attractive-serious-african-american-lady-6620517.jpg", false, null, "Dunphie", false, null, null, null, null, null, false, "3916744b-7e66-443a-bb20-aeabb9f50021", false, "25d73632-0715-40df-aec6-e4833dacdca6", null, 2 },
                    { "deb89161-642b-4348-9982-1943ce0afef5", 0, "7a9e0af8-2eb4-4000-ad19-b5e4bbad0e37", "pwalesby2@addthis.com", true, "Pyotr", "https://thumbs.dreamstime.com/z/attractive-serious-african-american-lady-6620517.jpg", false, null, "Walesby", false, null, null, null, null, null, false, "4d3fda26-10a8-4f90-b80e-a0af3682ce17", false, "e62dfff9-e41d-426c-acda-f0638d5d9d5b", null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "0f8b75ef-5795-4f04-843a-7feae7661f01",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2476), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2477), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "1a4ee5f0-0eab-4fe5-97e3-b0485c17384a",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2409), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2410), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "1cfc1884-2aae-4ac1-97c5-27f408f140f3",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2357), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2357), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "2f19959b-458f-42f8-927d-45ad1d66a2d8",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2392), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2393), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "3b1cc8f3-69e2-4ec0-8522-2c4e01b529c2",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2400), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2401), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "418f2b38-ae9e-49a8-9a8d-2ee99c8355cc",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2377), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2378), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "4b2c2c2c-3888-4214-9a3a-fa3075b9a373",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2467), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2468), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "4f33e4a3-2cb2-4ef9-9839-862fc58f64cd",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2453), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2454), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "55f7d2a7-3b49-4e87-88c0-6c88e2a0e17c",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2365), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2366), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "5f68d2e2-7ce6-4310-bd29-9a46e5b60949",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2480), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2481), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "64a4c5a1-7782-4b4e-90b2-704dcd9d8d24",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2388), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2388), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "6e6de32d-0682-4f5a-96d4-96c2f77f8f98",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2487), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2487), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "7e4ed35f-e1a5-4a2a-baad-b6a6a2a8b5bb",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2458), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2459), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "878a3464-58b1-49b4-bdc3-ea201b6ac6ae",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2396), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2397), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "90a1eb50-5e54-41b2-b5b9-5d3d25f7e031",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2282), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2283), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "9b03f725-521f-4a90-9f4a-7c5b89c2465c",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2278), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2278), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "a39b8e55-7a88-4912-9d08-45b33c550a6e",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2361), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2362), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "a5454a2a-6e34-4a35-8e54-8789ee849c4b",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2383), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2384), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "aa12e4eb-40a8-4cd8-837d-3dd207f56b97",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2404), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2405), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "b79b1c76-1fb0-4a44-a758-0b6e524f245b",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2413), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2414), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "b946508d-6a67-4f2e-93b0-2f1d15cb482e\r\n",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2231), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2247), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "c45330b1-d6b3-4a7a-8f92-4f33a11b3195",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate", "SellingPrice" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2492), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2492), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2492), 0.00m });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "c93cf864-d273-44d2-98b3-b36138de7b9b",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2352), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2352), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "d0cde2d1-e9f7-4b1a-8a84-04ee55fb4a7e",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2419), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2420), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "d764f82c-e4e1-4e50-825e-54c8b8b8eeb1",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2369), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2370), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "e40bb26b-6f9b-4a53-b8dd-0c1cfb9daee2",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2347), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2348), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "e4d9c0b1-7c6c-4eb1-9f5d-7c0195d2bf88",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2472), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2472), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "f1af480b-44a0-48d1-a20d-d2e1b3bd46d4",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2373), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2374), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "f78b929f-71cc-4fb2-b0d8-3188194c73f3",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2463), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2463), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "f7c8e0ae-3fb7-4e49-a42d-59b40698665a",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2273), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(2273), new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Local).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "Transporters",
                keyColumn: "UserId",
                keyValue: "25d73632-0715-40df-aec6-e4833dacdca6",
                column: "DateAdded",
                value: new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Transporters",
                keyColumn: "UserId",
                keyValue: "b017365a-2f2d-463d-8707-66a9b590839a",
                column: "DateAdded",
                value: new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Transporters",
                keyColumn: "UserId",
                keyValue: "e62dfff9-e41d-426c-acda-f0638d5d9d5b",
                column: "DateAdded",
                value: new DateTime(2023, 12, 11, 18, 23, 5, 365, DateTimeKind.Utc).AddTicks(5874));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18affb8b-20fa-4ad8-836d-c05d65049936");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "417576b7-bf4e-4a6f-979d-bdf5ab0a8da9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd74ae65-8750-4859-991f-a62517a700ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0aa1e278-d70d-474d-b19a-5115a408551d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "714b5c33-216f-4958-aa92-40ad9aa43912");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "deb89161-642b-4348-9982-1943ce0afef5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14f9c5ba-0a14-462d-bd31-a0f5ea7a3b5c", null, "Admin", "ADMIN" },
                    { "3fda14c9-bdbb-4dc8-a0aa-9772b04bebf9", null, "Transporter", "TRANSPORTER" },
                    { "6b07b7e9-8a36-4c9c-98ee-9cc30306214e", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "IsVerified", "KycId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName", "UserType" },
                values: new object[,]
                {
                    { "918549d8-bc16-4b1c-8c58-5a7130aed815", 0, "e544901f-0a8e-4b00-bdca-0e49c128c2bb", "cmounch1@behance.net", true, "Chane", "https://images.pexels.com/photos/2379004/pexels-photo-2379004.jpeg", false, null, "Mounch", false, null, null, null, null, null, false, "52a5b2e3-487c-4044-95a1-8b5dbe130be9", false, "b017365a-2f2d-463d-8707-66a9b590839a", null, 2 },
                    { "b91cbc79-498a-4378-87ea-547574a0befe", 0, "95a2d923-174b-4070-ac17-d05fd041822d", "pwalesby2@addthis.com", true, "Pyotr", "https://thumbs.dreamstime.com/z/attractive-serious-african-american-lady-6620517.jpg", false, null, "Walesby", false, null, null, null, null, null, false, "5e831d5e-0280-41ec-810c-c5ecc0e547bd", false, "e62dfff9-e41d-426c-acda-f0638d5d9d5b", null, 2 },
                    { "d9055518-042f-4edb-af4e-fb406a59888b", 0, "bf6bf002-d4ae-441f-a17a-fea74d332e57", "ddunphie0@amazon.com", true, "Doretta", "https://thumbs.dreamstime.com/z/attractive-serious-african-american-lady-6620517.jpg", false, null, "Dunphie", false, null, null, null, null, null, false, "e96394bd-5391-425f-9e70-88f009552192", false, "25d73632-0715-40df-aec6-e4833dacdca6", null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "0f8b75ef-5795-4f04-843a-7feae7661f01",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7988), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7988), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "1a4ee5f0-0eab-4fe5-97e3-b0485c17384a",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7951), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7952), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "1cfc1884-2aae-4ac1-97c5-27f408f140f3",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7873), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7874), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "2f19959b-458f-42f8-927d-45ad1d66a2d8",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7934), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7935), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "3b1cc8f3-69e2-4ec0-8522-2c4e01b529c2",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7942), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7943), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "418f2b38-ae9e-49a8-9a8d-2ee99c8355cc",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7895), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7895), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "4b2c2c2c-3888-4214-9a3a-fa3075b9a373",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7980), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7981), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "4f33e4a3-2cb2-4ef9-9839-862fc58f64cd",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7968), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7969), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "55f7d2a7-3b49-4e87-88c0-6c88e2a0e17c",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7881), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7882), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "5f68d2e2-7ce6-4310-bd29-9a46e5b60949",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7993), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7994), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "64a4c5a1-7782-4b4e-90b2-704dcd9d8d24",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7929), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7930), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "6e6de32d-0682-4f5a-96d4-96c2f77f8f98",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7997), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7998), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "7e4ed35f-e1a5-4a2a-baad-b6a6a2a8b5bb",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7972), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7973), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "878a3464-58b1-49b4-bdc3-ea201b6ac6ae",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7938), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7939), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "90a1eb50-5e54-41b2-b5b9-5d3d25f7e031",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7860), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7861), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "9b03f725-521f-4a90-9f4a-7c5b89c2465c",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7844), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7845), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "a39b8e55-7a88-4912-9d08-45b33c550a6e",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7877), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7878), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "a5454a2a-6e34-4a35-8e54-8789ee849c4b",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7898), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7899), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "aa12e4eb-40a8-4cd8-837d-3dd207f56b97",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7947), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7947), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "b79b1c76-1fb0-4a44-a758-0b6e524f245b",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7958), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7959), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "b946508d-6a67-4f2e-93b0-2f1d15cb482e\r\n",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7804), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7817), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "c45330b1-d6b3-4a7a-8f92-4f33a11b3195",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate", "SellingPrice" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(8001), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(8002), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(8001), 1799.99m });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "c93cf864-d273-44d2-98b3-b36138de7b9b",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7868), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7869), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "d0cde2d1-e9f7-4b1a-8a84-04ee55fb4a7e",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7962), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7963), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "d764f82c-e4e1-4e50-825e-54c8b8b8eeb1",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7885), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7886), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "e40bb26b-6f9b-4a53-b8dd-0c1cfb9daee2",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7864), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7865), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "e4d9c0b1-7c6c-4eb1-9f5d-7c0195d2bf88",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7984), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7984), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "f1af480b-44a0-48d1-a20d-d2e1b3bd46d4",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7889), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7890), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "f78b929f-71cc-4fb2-b0d8-3188194c73f3",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7976), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7976), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "f7c8e0ae-3fb7-4e49-a42d-59b40698665a",
                columns: new[] { "BookCreationId", "DateAdded", "ListedDate" },
                values: new object[] { new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7840), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Utc).AddTicks(7840), new DateTime(2023, 12, 11, 18, 18, 17, 425, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Transporters",
                keyColumn: "UserId",
                keyValue: "25d73632-0715-40df-aec6-e4833dacdca6",
                column: "DateAdded",
                value: new DateTime(2023, 12, 11, 18, 18, 17, 426, DateTimeKind.Utc).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Transporters",
                keyColumn: "UserId",
                keyValue: "b017365a-2f2d-463d-8707-66a9b590839a",
                column: "DateAdded",
                value: new DateTime(2023, 12, 11, 18, 18, 17, 426, DateTimeKind.Utc).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Transporters",
                keyColumn: "UserId",
                keyValue: "e62dfff9-e41d-426c-acda-f0638d5d9d5b",
                column: "DateAdded",
                value: new DateTime(2023, 12, 11, 18, 18, 17, 426, DateTimeKind.Utc).AddTicks(309));
        }
    }
}
