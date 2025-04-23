using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Infastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f8dff6df-34b7-4bcf-9366-3be7be67827a", 0, "b0a5ebe4-f638-469b-8deb-3e367e0eb754", null, false, false, null, null, null, "AQAAAAIAAYagAAAAEGXRVAgKo7Il0p5KIJTxWpd7WcRPs3MUFiQYI9l8uzvqDzLak73ETyQrPDYFUreB5Q==", null, false, "5ce28af2-3409-4f06-879c-2017ec5f7c9b", false, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8dff6df-34b7-4bcf-9366-3be7be67827a");
        }
    }
}
