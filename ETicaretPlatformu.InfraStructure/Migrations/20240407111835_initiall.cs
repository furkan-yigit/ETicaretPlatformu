using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretPlatformu.InfraStructure.Migrations
{
    public partial class initiall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "920a09b4-cf4d-471d-b456-673d8685ee5d", new DateTime(2024, 4, 7, 14, 18, 34, 250, DateTimeKind.Local).AddTicks(7055), "AQAAAAEAACcQAAAAEECNNkCS4UCVtjftxrXK1pEK46Z0HQ1rJ6/VMPyHBkISMHqm8om/I77/KFEAZ1whGQ==", "57fbcf73-778e-4862-bc1f-65139b39ba04" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateDate", "DeleteDate", "Description", "ImagePath", "Name", "Price", "Status", "StockQuantity", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7904), null, "Next Generation Smart Phone", "/images/ProductImages/smartPhone.jpg", "Smart Phone", 2000m, 1, 100, null },
                    { 2, 1, new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7914), null, "Wireless Headphones", "/images/ProductImages/HeadPhones.jpg", "Headphones", 100m, 1, 200, null },
                    { 3, 2, new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7918), null, "New Season Women's Dress", "/images/ProductImages/Dress.jpg", "Dress", 150m, 1, 150, null },
                    { 4, 2, new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7920), null, "Slim Fit Men's Shirt", "/images/ProductImages/Shirt.jpg", "Shirt", 80m, 1, 120, null },
                    { 5, 3, new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7922), null, "5-Function Kitchen Robot", "/images/ProductImages/KitchenRobot.jpg", "Kitchen Robot", 300m, 1, 80, null },
                    { 6, 3, new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7925), null, "Flowering Houseplant", "/images/ProductImages/HousePlant.jpg", "Houseplant", 50m, 1, 300, null },
                    { 7, 4, new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7926), null, "Latest Science Fiction Novel", "/images/ProductImages/ScienceFictionNovel.jpg", "Fiction Novel", 20m, 1, 500, null },
                    { 8, 4, new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7928), null, "Ottoman Empire History Book", "/images/ProductImages/HistoryBook.jpg", "History Book", 30m, 1, 400, null },
                    { 9, 5, new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7929), null, "Yoga Exercise Mat", "/images/ProductImages/YogaMat.jpg", "Yoga Mat", 25m, 1, 200, null },
                    { 10, 5, new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7933), null, "2-Person Camping Tent", "/images/ProductImages/CampingTent.jpg", "Camping Tent", 150m, 1, 100, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c65f9e0-feb9-438e-8f0c-c59bfecda5a3", new DateTime(2024, 4, 7, 14, 11, 41, 570, DateTimeKind.Local).AddTicks(223), "AQAAAAEAACcQAAAAEKivSCGKXXDTexC3BliTcPP2rDlMiFotI2OHLtqkFiMT2q2TtqOO0xGrBHYYZaCd9A==", "59ac1bbb-18c2-423f-87f0-0a9996828aa8" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 11, 41, 579, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 11, 41, 579, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 11, 41, 579, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 11, 41, 579, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 11, 41, 579, DateTimeKind.Local).AddTicks(232));
        }
    }
}
