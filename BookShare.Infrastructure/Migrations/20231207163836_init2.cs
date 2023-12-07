using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f79fddc-6ee2-4502-8d16-8b1d65be059e", null, "User", "USER" },
                    { "5614bd8b-d005-44ea-8d08-550c93a1fedc", null, "Admin", "ADMIN" },
                    { "7e4bdd31-acc9-4398-bef9-82000823b6e4", null, "Transporter", "TRANSPORTER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f79fddc-6ee2-4502-8d16-8b1d65be059e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5614bd8b-d005-44ea-8d08-550c93a1fedc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e4bdd31-acc9-4398-bef9-82000823b6e4");
        }
    }
}
