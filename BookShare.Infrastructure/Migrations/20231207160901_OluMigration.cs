using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class OluMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_KYCs_KycId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Transporters_TransportId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_KycId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "BooksForSale");

            migrationBuilder.AddColumn<string>(
                name: "HarmfulContentCount",
                table: "BooksForSale",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "BooksForSale",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDisabled",
                table: "BooksForSale",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ListingType",
                table: "BooksForSale",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Publisher",
                table: "BooksForSale",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TransportId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "KycId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_KycId",
                table: "AspNetUsers",
                column: "KycId",
                unique: true,
                filter: "[KycId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_KYCs_KycId",
                table: "AspNetUsers",
                column: "KycId",
                principalTable: "KYCs",
                principalColumn: "KycId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Transporters_TransportId",
                table: "AspNetUsers",
                column: "TransportId",
                principalTable: "Transporters",
                principalColumn: "TransporterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_KYCs_KycId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Transporters_TransportId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_KycId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HarmfulContentCount",
                table: "BooksForSale");

            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "BooksForSale");

            migrationBuilder.DropColumn(
                name: "IsDisabled",
                table: "BooksForSale");

            migrationBuilder.DropColumn(
                name: "ListingType",
                table: "BooksForSale");

            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "BooksForSale");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "BooksForSale",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TransportId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KycId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_KycId",
                table: "AspNetUsers",
                column: "KycId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_KYCs_KycId",
                table: "AspNetUsers",
                column: "KycId",
                principalTable: "KYCs",
                principalColumn: "KycId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Transporters_TransportId",
                table: "AspNetUsers",
                column: "TransportId",
                principalTable: "Transporters",
                principalColumn: "TransporterId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
