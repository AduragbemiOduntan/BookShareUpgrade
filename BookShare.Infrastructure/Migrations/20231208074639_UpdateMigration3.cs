using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BooksForSale",
                columns: new[] { "BookForSaleId", "Author", "BookCategory", "BookCondition", "BookDescription", "BookName", "CreatorId", "DateAdded", "DateModified", "Subject", "HarmfulContentCount", "ISBN", "ImageUrl", "IsDeleted", "IsDisabled", "IsSoldOut", "ListedDate", "ListingType", "LocationId", "MarketPrice", "Publisher", "RequestId", "SellingPrice", "Subject1", "UserId" },
                values: new object[,]
                {
                    { "0bb6a6f4-d16a-4fbf-bf23-926b4987ff7a", "Robert Miller", 1, 2, "Business studies textbook", "Introduction to Business Studies", null, new DateTime(2023, 12, 8, 8, 46, 39, 35, DateTimeKind.Utc).AddTicks(6759), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "978-3-456-78901-2", null, false, null, false, new DateTime(2023, 12, 8, 7, 46, 39, 35, DateTimeKind.Utc).AddTicks(6761), 1, null, 34.99m, null, null, 24.99m, 10, null },
                    { "1b55e794-02ce-48c4-b2a1-49770e97c158", "Emily White", 0, 0, "Introduction to chemistry", "Chemistry Basics", null, new DateTime(2023, 12, 8, 8, 46, 39, 35, DateTimeKind.Utc).AddTicks(6764), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "978-4-567-89012-3", null, false, null, false, new DateTime(2023, 12, 8, 7, 46, 39, 35, DateTimeKind.Utc).AddTicks(6767), 0, null, 27.99m, null, null, 17.99m, 6, null },
                    { "25a9cfcc-24c3-4fe4-83ef-6f82e8704b4e", "John Doe", 0, 3, "Economics textbook", "Introduction to Economics", null, new DateTime(2023, 12, 8, 8, 46, 39, 35, DateTimeKind.Utc).AddTicks(6689), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "978-0-123-45678-9", null, false, null, false, new DateTime(2023, 12, 8, 7, 46, 39, 35, DateTimeKind.Utc).AddTicks(6709), 1, null, 29.99m, null, null, 19.99m, 9, null },
                    { "3b59a7f2-91a0-4991-bb2b-3ee5d779d15b", "Charlotte Williams", 4, 3, "A compilation of classic literature", "Literary Classics Collection", null, new DateTime(2023, 12, 8, 8, 46, 39, 35, DateTimeKind.Utc).AddTicks(6787), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "978-8-901-23456-7", null, false, null, false, new DateTime(2023, 12, 8, 7, 46, 39, 35, DateTimeKind.Utc).AddTicks(6789), 1, null, 54.99m, null, null, 44.99m, 13, null },
                    { "3fcd4fe1-d8b7-4f9a-8625-8c92c8317409", "John Doe", 0, 1, "Physics textbook for beginners", "Introduction to Physics", null, new DateTime(2023, 12, 8, 8, 46, 39, 35, DateTimeKind.Utc).AddTicks(6721), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, "978-1-234-56789-0", null, false, null, false, new DateTime(2023, 12, 8, 7, 46, 39, 35, DateTimeKind.Utc).AddTicks(6723), 1, null, 49.99m, null, null, 39.99m, 5, null },
                    { "5f1c6d9a-3e85-46b0-b7c4-1e7df41e084e", "Ryan Mitchell", 1, 1, "Understanding ethical business practices", "Business Ethics", null, new DateTime(2023, 12, 8, 8, 46, 39, 35, DateTimeKind.Utc).AddTicks(6802), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, "978-3-333-44444-4", null, false, null, false, new DateTime(2023, 12, 8, 7, 46, 39, 35, DateTimeKind.Utc).AddTicks(6803), 1, null, 39.99m, null, null, 29.99m, 10, null },
                    { "6e7e78a5-2b1e-4a71-b1a2-5b35bf7e7c2c", "Michael Brown", 3, 1, "Introduction to computer science", "Computer Science Fundamentals", null, new DateTime(2023, 12, 8, 8, 46, 39, 35, DateTimeKind.Utc).AddTicks(6770), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "978-5-678-90123-4", null, false, null, false, new DateTime(2023, 12, 8, 7, 46, 39, 35, DateTimeKind.Utc).AddTicks(6772), 0, null, 39.99m, null, null, 29.99m, 11, null },
                    { "735bf9c0-947a-4b29-b3c4-0e8eab31c34b", "Daniel Turner", 0, 0, "Fundamental concepts of physics", "Physics for Beginners", null, new DateTime(2023, 12, 8, 8, 46, 39, 35, DateTimeKind.Utc).AddTicks(6792), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "978-9-012-34567-8", null, false, null, false, new DateTime(2023, 12, 8, 7, 46, 39, 35, DateTimeKind.Utc).AddTicks(6793), 1, null, 29.99m, null, null, 19.99m, 5, null },
                    { "7e6e1b1d-7d91-45d7-a9d4-0e953ab12c3a", "Olivia Davis", 2, 2, "Discovering the world of art", "Art Appreciation", null, new DateTime(2023, 12, 8, 8, 46, 39, 35, DateTimeKind.Utc).AddTicks(6797), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "978-0-111-22222-2", null, false, null, false, new DateTime(2023, 12, 8, 7, 46, 39, 35, DateTimeKind.Utc).AddTicks(6798), 0, null, 34.99m, null, null, 24.99m, 16, null },
                    { "8eaa6d2b-e4cc-4c48-9205-8ef9f2c2c5b8", "Emma Turner", 0, 2, "Exploring the environment and ecosystems", "Environmental Science", null, new DateTime(2023, 12, 8, 8, 46, 39, 35, DateTimeKind.Utc).AddTicks(6806), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, "978-5-555-66666-6", null, false, null, false, new DateTime(2023, 12, 8, 7, 46, 39, 35, DateTimeKind.Utc).AddTicks(6808), 0, null, 49.99m, null, null, 39.99m, 1, null },
                    { "8eb4f536-7680-4a77-9f84-3c6ac75c77d2", "Jane Smith", 1, 2, "Macroeconomics textbook", "Macroeconomics Explained", null, new DateTime(2023, 12, 8, 8, 46, 39, 35, DateTimeKind.Utc).AddTicks(6714), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "978-0-987-65432-1", null, false, null, false, new DateTime(2023, 12, 8, 7, 46, 39, 35, DateTimeKind.Utc).AddTicks(6717), 0, null, 39.99m, null, null, 29.99m, 9, null },
                    { "9a1d8c0a-b7c4-43aa-89a2-9109d77477db", "David Thompson", 4, 2, "Exploring historical events", "History Uncovered", null, new DateTime(2023, 12, 8, 8, 46, 39, 35, DateTimeKind.Utc).AddTicks(6776), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, "978-6-789-01234-5", null, false, null, false, new DateTime(2023, 12, 8, 7, 46, 39, 35, DateTimeKind.Utc).AddTicks(6777), 1, null, 44.99m, null, null, 34.99m, 4, null },
                    { "b3268c1b-04d0-4d07-b393-853e228f5aaf", "Sophie Clark", 0, 1, "Fun math problems for enthusiasts", "Math Puzzles and Challenges", null, new DateTime(2023, 12, 8, 8, 46, 39, 35, DateTimeKind.Utc).AddTicks(6782), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "978-7-890-12345-6", null, false, null, false, new DateTime(2023, 12, 8, 7, 46, 39, 35, DateTimeKind.Utc).AddTicks(6784), 0, null, 19.99m, null, null, 9.99m, 0, null },
                    { "d450b2f3-4d20-4d22-8d4e-4e6ef3a429b3", "Sophia Johnson", 4, 3, "Introduction to philosophical concepts", "Philosophy Fundamentals", null, new DateTime(2023, 12, 8, 8, 46, 39, 35, DateTimeKind.Utc).AddTicks(6811), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "978-6-666-77777-7", null, false, null, false, new DateTime(2023, 12, 8, 7, 46, 39, 35, DateTimeKind.Utc).AddTicks(6812), 1, null, 24.99m, null, null, 14.99m, 2, null },
                    { "fd6726e7-0dbb-4e4c-bc29-4cd4c6e8ecf7", "Alice Johnson", 4, 3, "Grammar guide for language learners", "English Grammar Essentials", null, new DateTime(2023, 12, 8, 8, 46, 39, 35, DateTimeKind.Utc).AddTicks(6725), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "978-2-345-67890-1", null, false, null, false, new DateTime(2023, 12, 8, 7, 46, 39, 35, DateTimeKind.Utc).AddTicks(6727), 1, null, 29.99m, null, null, 19.99m, 3, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "0bb6a6f4-d16a-4fbf-bf23-926b4987ff7a");

            migrationBuilder.DeleteData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "1b55e794-02ce-48c4-b2a1-49770e97c158");

            migrationBuilder.DeleteData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "25a9cfcc-24c3-4fe4-83ef-6f82e8704b4e");

            migrationBuilder.DeleteData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "3b59a7f2-91a0-4991-bb2b-3ee5d779d15b");

            migrationBuilder.DeleteData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "3fcd4fe1-d8b7-4f9a-8625-8c92c8317409");

            migrationBuilder.DeleteData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "5f1c6d9a-3e85-46b0-b7c4-1e7df41e084e");

            migrationBuilder.DeleteData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "6e7e78a5-2b1e-4a71-b1a2-5b35bf7e7c2c");

            migrationBuilder.DeleteData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "735bf9c0-947a-4b29-b3c4-0e8eab31c34b");

            migrationBuilder.DeleteData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "7e6e1b1d-7d91-45d7-a9d4-0e953ab12c3a");

            migrationBuilder.DeleteData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "8eaa6d2b-e4cc-4c48-9205-8ef9f2c2c5b8");

            migrationBuilder.DeleteData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "8eb4f536-7680-4a77-9f84-3c6ac75c77d2");

            migrationBuilder.DeleteData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "9a1d8c0a-b7c4-43aa-89a2-9109d77477db");

            migrationBuilder.DeleteData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "b3268c1b-04d0-4d07-b393-853e228f5aaf");

            migrationBuilder.DeleteData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "d450b2f3-4d20-4d22-8d4e-4e6ef3a429b3");

            migrationBuilder.DeleteData(
                table: "BooksForSale",
                keyColumn: "BookForSaleId",
                keyValue: "fd6726e7-0dbb-4e4c-bc29-4cd4c6e8ecf7");
        }
    }
}
