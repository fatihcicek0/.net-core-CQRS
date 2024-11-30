using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CQRS_.net_core.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 27, 18, 29, 23, 147, DateTimeKind.Local).AddTicks(8177), "Electronics" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 27, 18, 29, 23, 148, DateTimeKind.Local).AddTicks(2086), "Electronics, Movies & Toys" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 27, 18, 29, 23, 148, DateTimeKind.Local).AddTicks(2207), "Garden, Home & Outdoors" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 18, 29, 23, 149, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 18, 29, 23, 149, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 18, 29, 23, 149, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 18, 29, 23, 149, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 18, 29, 23, 167, DateTimeKind.Local).AddTicks(4900), "Velit reprehenderit dolorem layıkıyla dicta.", "Kutusu." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 18, 29, 23, 167, DateTimeKind.Local).AddTicks(4966), "Et aut molestiae ona veritatis.", "Kalemi." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 18, 29, 23, 167, DateTimeKind.Local).AddTicks(5076), "Suscipit aut in non düşünüyor.", "Quia." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 18, 29, 23, 172, DateTimeKind.Local).AddTicks(8331), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6.451718492904680m, 981.60m, "Unbranded Plastic Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 18, 29, 23, 172, DateTimeKind.Local).AddTicks(8446), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 5.149885604525710m, 808.10m, "Unbranded Granite Shoes" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 27, 18, 24, 38, 502, DateTimeKind.Local).AddTicks(767), "Movies & Jewelery" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 27, 18, 24, 38, 502, DateTimeKind.Local).AddTicks(1158), "Sports" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 11, 27, 18, 24, 38, 502, DateTimeKind.Local).AddTicks(1299), "Kids, Games & Books" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 18, 24, 38, 503, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 18, 24, 38, 503, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 18, 24, 38, 503, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 18, 24, 38, 503, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 18, 24, 38, 515, DateTimeKind.Local).AddTicks(1841), "Doğru magni için sed tempora.", "Kapının." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 18, 24, 38, 515, DateTimeKind.Local).AddTicks(1890), "Biber mutlu salladı consequatur voluptate.", "Sit." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 18, 24, 38, 515, DateTimeKind.Local).AddTicks(2051), "İpsam ipsum illo veritatis mi.", "Bilgiyasayarı." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 18, 24, 38, 520, DateTimeKind.Local).AddTicks(2802), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 7.084794449427640m, 503.83m, "Unbranded Soft Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 11, 27, 18, 24, 38, 520, DateTimeKind.Local).AddTicks(2891), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 4.158894628442060m, 425.20m, "Incredible Frozen Gloves" });
        }
    }
}
