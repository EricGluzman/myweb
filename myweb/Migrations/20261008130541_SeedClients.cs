using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace myweb.Migrations
{
    /// <inheritdoc />
    public partial class SeedClients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "FullName", "JoinDate", "Phone" },
                values: new object[,]
                {
                    { 1, "daniel.cohen@gmail.com", "Daniel Cohen", new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "050-1234567" },
                    { 2, "noa.levi@gmail.com", "Noa Levi", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "052-7654321" },
                    { 3, "yossi.m@walla.co.il", "Yossi Mizrahi", new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "054-1112233" },
                    { 4, "maya.f@gmail.com", "Maya Friedman", new DateTime(2026, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "avi.peretz@hotmail.com", "Avi Peretz", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "053-9988776" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
