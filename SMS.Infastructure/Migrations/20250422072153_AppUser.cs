using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Infastructure.Migrations
{
    /// <inheritdoc />
    public partial class AppUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ccc0ba4-e362-4249-8ac9-50a37119ed01");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "62645c32-afca-4017-b846-23487cdd1442", 0, "7c7c4998-495a-4e1c-86bb-faa0bc04a638", null, false, false, null, null, null, "AQAAAAIAAYagAAAAEHMb2RUMGY8FBcXsMLywPOikwJLnaArEKhHGGivuP2g+UOczi4DUK2/rn0PWS8sdqg==", null, false, "60d6ae96-1e29-4935-ac89-cfaadf52eda5", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62645c32-afca-4017-b846-23487cdd1442");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9ccc0ba4-e362-4249-8ac9-50a37119ed01", 0, "dd9975d6-6034-4af2-963b-e300fa3c8c2c", null, false, false, null, null, null, "AQAAAAIAAYagAAAAEIENtzC/6fOen1/McXeM+6g4AQ9lpO4idacE+lfxIVqKIEEoTAwAEUXqnYlOKBHI8w==", null, false, "b11332c6-e9c9-4fdd-9d7d-6186783777c3", false, null });
        }
    }
}
