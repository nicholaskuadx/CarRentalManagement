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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "dca48e15-0efe-42e8-b61a-d6f9707a5d15", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAECJ0xkBqlPIW2xrtB5/Is6gfpA66N2xbmPQ8+/sGVUAzEudR9NgEKSIZPd9NfLisjg==", null, false, "85458525-9d1a-4ca0-9cd1-1c925dfed447", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 9, 52, 56, 45, DateTimeKind.Local).AddTicks(7802), new DateTime(2025, 12, 4, 9, 52, 56, 45, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 9, 52, 56, 45, DateTimeKind.Local).AddTicks(7828), new DateTime(2025, 12, 4, 9, 52, 56, 45, DateTimeKind.Local).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 9, 52, 56, 45, DateTimeKind.Local).AddTicks(8103), new DateTime(2025, 12, 4, 9, 52, 56, 45, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 9, 52, 56, 45, DateTimeKind.Local).AddTicks(8106), new DateTime(2025, 12, 4, 9, 52, 56, 45, DateTimeKind.Local).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 9, 52, 56, 45, DateTimeKind.Local).AddTicks(8215), new DateTime(2025, 12, 4, 9, 52, 56, 45, DateTimeKind.Local).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 9, 52, 56, 45, DateTimeKind.Local).AddTicks(8219), new DateTime(2025, 12, 4, 9, 52, 56, 45, DateTimeKind.Local).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 9, 52, 56, 45, DateTimeKind.Local).AddTicks(8222), new DateTime(2025, 12, 4, 9, 52, 56, 45, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 9, 52, 56, 45, DateTimeKind.Local).AddTicks(8224), new DateTime(2025, 12, 4, 9, 52, 56, 45, DateTimeKind.Local).AddTicks(8225) });

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
