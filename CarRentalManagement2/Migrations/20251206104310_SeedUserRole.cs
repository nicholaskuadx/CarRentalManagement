using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement2.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DrivingLicense",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "2774c6a7-c293-4a6a-960d-b735394384b8", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFExRK+WSMoRNGoOZn3GxqflrYWl61WQKU7PUunTZpMzFhizaJM3H5PIT3Mao0ZRgw==", null, false, "5e701296-9d71-476a-8da6-151f72a6c831", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 6, 18, 43, 9, 802, DateTimeKind.Local).AddTicks(197), new DateTime(2025, 12, 6, 18, 43, 9, 802, DateTimeKind.Local).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 6, 18, 43, 9, 802, DateTimeKind.Local).AddTicks(210), new DateTime(2025, 12, 6, 18, 43, 9, 802, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 6, 18, 43, 9, 802, DateTimeKind.Local).AddTicks(378), new DateTime(2025, 12, 6, 18, 43, 9, 802, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 6, 18, 43, 9, 802, DateTimeKind.Local).AddTicks(380), new DateTime(2025, 12, 6, 18, 43, 9, 802, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 6, 18, 43, 9, 802, DateTimeKind.Local).AddTicks(464), new DateTime(2025, 12, 6, 18, 43, 9, 802, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 6, 18, 43, 9, 802, DateTimeKind.Local).AddTicks(466), new DateTime(2025, 12, 6, 18, 43, 9, 802, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 6, 18, 43, 9, 802, DateTimeKind.Local).AddTicks(468), new DateTime(2025, 12, 6, 18, 43, 9, 802, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 6, 18, 43, 9, 802, DateTimeKind.Local).AddTicks(469), new DateTime(2025, 12, 6, 18, 43, 9, 802, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "DrivingLicense",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 40, 32, 791, DateTimeKind.Local).AddTicks(3493), new DateTime(2025, 12, 3, 11, 40, 32, 791, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 40, 32, 791, DateTimeKind.Local).AddTicks(3505), new DateTime(2025, 12, 3, 11, 40, 32, 791, DateTimeKind.Local).AddTicks(3505) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 40, 32, 791, DateTimeKind.Local).AddTicks(3641), new DateTime(2025, 12, 3, 11, 40, 32, 791, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 40, 32, 791, DateTimeKind.Local).AddTicks(3643), new DateTime(2025, 12, 3, 11, 40, 32, 791, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 40, 32, 791, DateTimeKind.Local).AddTicks(3706), new DateTime(2025, 12, 3, 11, 40, 32, 791, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 40, 32, 791, DateTimeKind.Local).AddTicks(3708), new DateTime(2025, 12, 3, 11, 40, 32, 791, DateTimeKind.Local).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 40, 32, 791, DateTimeKind.Local).AddTicks(3709), new DateTime(2025, 12, 3, 11, 40, 32, 791, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 11, 40, 32, 791, DateTimeKind.Local).AddTicks(3711), new DateTime(2025, 12, 3, 11, 40, 32, 791, DateTimeKind.Local).AddTicks(3711) });
        }
    }
}
