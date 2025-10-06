using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem2.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8d3bef90-ffd2-41c8-9bc3-70509bbd3618", null, "Administrator", "ADMINISTRATOR" },
                    { "cdef1c32-a3ae-4b89-959e-7dacc4071812", null, "Employee", "EMPLOYEE" },
                    { "d7992d20-4c09-4757-ad22-66ea5fe6aa1a", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "efe2f997-3bef-4396-a1a7-6ad83c127584", 0, "ad866032-3687-43fb-937b-46ab57627e39", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENonH/KhAF7MfMfT4dZCOESba8QTOTfvpY94suLUEO+E5NDRxmF5jv06CYoL4VZzqA==", null, false, "5cec5289-2e95-49ac-963c-4b69c0445177", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8d3bef90-ffd2-41c8-9bc3-70509bbd3618", "efe2f997-3bef-4396-a1a7-6ad83c127584" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdef1c32-a3ae-4b89-959e-7dacc4071812");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7992d20-4c09-4757-ad22-66ea5fe6aa1a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8d3bef90-ffd2-41c8-9bc3-70509bbd3618", "efe2f997-3bef-4396-a1a7-6ad83c127584" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d3bef90-ffd2-41c8-9bc3-70509bbd3618");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "efe2f997-3bef-4396-a1a7-6ad83c127584");
        }
    }
}
