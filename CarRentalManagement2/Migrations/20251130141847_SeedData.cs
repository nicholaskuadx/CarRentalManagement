using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement2.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 30, 22, 18, 46, 394, DateTimeKind.Local).AddTicks(9480), new DateTime(2025, 11, 30, 22, 18, 46, 394, DateTimeKind.Local).AddTicks(9491), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 30, 22, 18, 46, 394, DateTimeKind.Local).AddTicks(9493), new DateTime(2025, 11, 30, 22, 18, 46, 394, DateTimeKind.Local).AddTicks(9493), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 30, 22, 18, 46, 394, DateTimeKind.Local).AddTicks(9643), new DateTime(2025, 11, 30, 22, 18, 46, 394, DateTimeKind.Local).AddTicks(9643), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 30, 22, 18, 46, 394, DateTimeKind.Local).AddTicks(9645), new DateTime(2025, 11, 30, 22, 18, 46, 394, DateTimeKind.Local).AddTicks(9645), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 30, 22, 18, 46, 394, DateTimeKind.Local).AddTicks(9696), new DateTime(2025, 11, 30, 22, 18, 46, 394, DateTimeKind.Local).AddTicks(9696), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 30, 22, 18, 46, 394, DateTimeKind.Local).AddTicks(9697), new DateTime(2025, 11, 30, 22, 18, 46, 394, DateTimeKind.Local).AddTicks(9698), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 30, 22, 18, 46, 394, DateTimeKind.Local).AddTicks(9699), new DateTime(2025, 11, 30, 22, 18, 46, 394, DateTimeKind.Local).AddTicks(9699), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 30, 22, 18, 46, 394, DateTimeKind.Local).AddTicks(9700), new DateTime(2025, 11, 30, 22, 18, 46, 394, DateTimeKind.Local).AddTicks(9701), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
