using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksForSale_AspNetUsers_UserId",
                table: "BooksForSale");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksForSale_Locations_LocationId",
                table: "BooksForSale");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "BooksForSale",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LocationId",
                table: "BooksForSale",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksForSale_AspNetUsers_UserId",
                table: "BooksForSale",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksForSale_Locations_LocationId",
                table: "BooksForSale",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksForSale_AspNetUsers_UserId",
                table: "BooksForSale");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksForSale_Locations_LocationId",
                table: "BooksForSale");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "BooksForSale",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocationId",
                table: "BooksForSale",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksForSale_AspNetUsers_UserId",
                table: "BooksForSale",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksForSale_Locations_LocationId",
                table: "BooksForSale",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
