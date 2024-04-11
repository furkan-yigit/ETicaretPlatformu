using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretPlatformu.InfraStructure.Migrations
{
    public partial class deleteSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31deef46-2f8b-4c7e-9b41-eb2683915eee", new DateTime(2024, 4, 7, 15, 25, 6, 940, DateTimeKind.Local).AddTicks(7850), "AQAAAAEAACcQAAAAEBd+bPqVFRItPRtaOyiW5DRxim6bcqxYsQsieyjIOVIMk3wLhvWdT7XzM5Wu3dW+aA==", "0d12309f-31ab-4c9f-921e-568f36d24f65" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 15, 25, 6, 948, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 15, 25, 6, 948, DateTimeKind.Local).AddTicks(1920));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7e8ada4-5be1-46c0-b5b3-e4b9af4e9100", new DateTime(2024, 4, 7, 0, 37, 18, 690, DateTimeKind.Local).AddTicks(4018), "AQAAAAEAACcQAAAAEDQ/NmxE2UYyCfXOJSqRI3h4MQGvutLOuNl41Ki1Iiex9DT8LYrnYd2hEi6s3Fi6xA==", "6e5cc54b-4d82-4346-9d82-8e6e361e1d91" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "Description", "Name", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2846), null, "Giyim Ürünleri", "Giyim", 1, null },
                    { 3, new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2847), null, "Ev ve Yaşam Ürünleri", "Ev & Yaşam", 1, null },
                    { 4, new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2848), null, "Kitaplar", "Kitap", 1, null },
                    { 5, new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2849), null, "Spor ve Outdoor Ürünleri", "Spor & Outdoor", 1, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateDate", "DeleteDate", "Description", "ImagePath", "Name", "Price", "Status", "StockQuantity", "UpdateDate" },
                values: new object[] { 2, 1, new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2883), null, "Wireless Headphones", "/images/ProductImages/HeadPhones.jpg", "Headphones", 100m, 1, 200, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateDate", "DeleteDate", "Description", "ImagePath", "Name", "Price", "Status", "StockQuantity", "UpdateDate" },
                values: new object[,]
                {
                    { 3, 2, new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2884), null, "New Season Women's Dress", "/images/ProductImages/Dress.jpg", "Dress", 150m, 1, 150, null },
                    { 4, 2, new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2886), null, "Slim Fit Men's Shirt", "/images/ProductImages/Shirt.jpg", "Shirt", 80m, 1, 120, null },
                    { 5, 3, new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2887), null, "5-Function Kitchen Robot", "/images/ProductImages/KitchenRobot.jpg", "Kitchen Robot", 300m, 1, 80, null },
                    { 6, 3, new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2889), null, "Flowering Houseplant", "/images/ProductImages/HousePlant.jpg", "Houseplant", 50m, 1, 300, null },
                    { 7, 4, new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2890), null, "Latest Science Fiction Novel", "/images/ProductImages/ScienceFictionNovel.jpg", "Fiction Novel", 20m, 1, 500, null },
                    { 8, 4, new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2892), null, "Ottoman Empire History Book", "/images/ProductImages/HistoryBook.jpg", "History Book", 30m, 1, 400, null },
                    { 9, 5, new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2893), null, "Yoga Exercise Mat", "/images/ProductImages/YogaMat.jpg", "Yoga Mat", 25m, 1, 200, null },
                    { 10, 5, new DateTime(2024, 4, 7, 0, 37, 18, 697, DateTimeKind.Local).AddTicks(2895), null, "2-Person Camping Tent", "/images/ProductImages/CampingTent.jpg", "Camping Tent", 150m, 1, 100, null }
                });
        }
    }
}
