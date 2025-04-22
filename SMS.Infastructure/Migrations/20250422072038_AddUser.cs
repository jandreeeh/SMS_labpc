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
                values: new object[] { "9ccc0ba4-e362-4249-8ac9-50a37119ed01", 0, "dd9975d6-6034-4af2-963b-e300fa3c8c2c", null, false, false, null, null, null, "AQAAAAIAAYagAAAAEIENtzC/6fOen1/McXeM+6g4AQ9lpO4idacE+lfxIVqKIEEoTAwAEUXqnYlOKBHI8w==", null, false, "b11332c6-e9c9-4fdd-9d7d-6186783777c3", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ccc0ba4-e362-4249-8ac9-50a37119ed01");
        }
    }
}
