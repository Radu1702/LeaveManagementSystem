using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem2.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "efe2f997-3bef-4396-a1a7-6ad83c127584",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8c6c7eb-3723-4c8b-aa31-6e25b1940c16", new DateOnly(1990, 1, 1), "Default", "Admin", "AQAAAAIAAYagAAAAEMo0TrdXaUun5Wu6gyKptUsXx3uwAFNSQXu4HR1tUnisKfM7SMsA2LjrOdMuDHeRgg==", "48524314-31dd-4c5f-9b27-8b3cfe716858" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "efe2f997-3bef-4396-a1a7-6ad83c127584",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad866032-3687-43fb-937b-46ab57627e39", "AQAAAAIAAYagAAAAENonH/KhAF7MfMfT4dZCOESba8QTOTfvpY94suLUEO+E5NDRxmF5jv06CYoL4VZzqA==", "5cec5289-2e95-49ac-963c-4b69c0445177" });
        }
    }
}
