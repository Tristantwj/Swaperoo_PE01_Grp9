using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Swaperoo_PE01_Grp9.Server.Migrations
{
    /// <inheritdoc />
    public partial class DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10c0242f-fd7d-4484-b604-9d684bf46109");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Region", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3a3ee928-a5b5-4a8a-b1ee-a62ae5faa152", 0, "e3fb1026-8e59-480c-b73b-6858a4183862", "frankofoedu@gmail.com", true, false, null, "Frank Ofoedu", null, "FRANKOFOEDU@GMAIL.COM", "AQAAAAIAAYagAAAAEBC37KePGXL+eISKn4f7cy5AXssYMmygGx1DC+vH608PRpp07Pp29UxIorsxeWCzFQ==", null, false, "YourRegion", "7c4bec2d-d556-4d2e-ad68-6ad936effd30", false, "frankofoedu@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a3ee928-a5b5-4a8a-b1ee-a62ae5faa152");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Region", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "10c0242f-fd7d-4484-b604-9d684bf46109", 0, "59d008c7-7846-4716-aa3b-841cfaf775a8", "frankofoedu@gmail.com", true, false, null, "Frank Ofoedu", null, "FRANKOFOEDU@GMAIL.COM", "AQAAAAIAAYagAAAAEHSAkL+vL1MUn210t/G9pKSnaOFBcfaSC2/tvYuqKYqjPcyptegW6DWcg5UiMxBA/A==", null, false, "YourRegion", "7f0729bb-3cc9-4165-b9e8-cde70eb2fd04", false, "frankofoedu@gmail.com" });
        }
    }
}
