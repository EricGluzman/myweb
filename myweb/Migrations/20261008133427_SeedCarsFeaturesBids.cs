using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace myweb.Migrations
{
    /// <inheritdoc />
    public partial class SeedCarsFeaturesBids : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Model", "PricePerDay", "Year" },
                values: new object[,]
                {
                    { 1, "Toyota", "Corolla", 180m, 2022 },
                    { 2, "Kia", "Picanto", 120m, 2023 },
                    { 3, "Tesla", "Model 3", 350m, 2024 }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Navigation system", "GPS" },
                    { 2, "Air conditioning", "AC" },
                    { 3, "Phone connection", "Bluetooth" }
                });

            migrationBuilder.InsertData(
                table: "Bids",
                columns: new[] { "Id", "Amount", "BidDate", "CarId", "ClientId" },
                values: new object[,]
                {
                    { 1, 200m, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, 220m, new DateTime(2026, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 3, 400m, new DateTime(2026, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "CarFeature",
                columns: new[] { "CarsId", "FeaturesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 3, 1 },
                    { 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarFeature",
                keyColumns: new[] { "CarsId", "FeaturesId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CarFeature",
                keyColumns: new[] { "CarsId", "FeaturesId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CarFeature",
                keyColumns: new[] { "CarsId", "FeaturesId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "CarFeature",
                keyColumns: new[] { "CarsId", "FeaturesId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
