using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretPlatformu.InfraStructure.Migrations
{
    public partial class qqwe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "015dbc1e-2fdc-4b98-97c8-49aa40533ff2", new DateTime(2024, 4, 6, 22, 38, 37, 263, DateTimeKind.Local).AddTicks(5458), "AQAAAAEAACcQAAAAEKRLFk5eChDr2prvxRMgt6wIwUOIdzIawJTuD6u1Xr76uEW6vCBH9g2B6E+PzGX6Nw==", "4d40ba5f-13f7-4786-a09a-c0dcf1859629" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "Description", "Name", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 6, 22, 38, 37, 264, DateTimeKind.Local).AddTicks(8339), null, "Elektronik Ürünler", "Elektronik", 1, null },
                    { 2, new DateTime(2024, 4, 6, 22, 38, 37, 264, DateTimeKind.Local).AddTicks(8343), null, "Giyim Ürünleri", "Giyim", 1, null },
                    { 3, new DateTime(2024, 4, 6, 22, 38, 37, 264, DateTimeKind.Local).AddTicks(8344), null, "Ev ve Yaşam Ürünleri", "Ev & Yaşam", 1, null },
                    { 4, new DateTime(2024, 4, 6, 22, 38, 37, 264, DateTimeKind.Local).AddTicks(8345), null, "Kitaplar", "Kitap", 1, null },
                    { 5, new DateTime(2024, 4, 6, 22, 38, 37, 264, DateTimeKind.Local).AddTicks(8346), null, "Spor ve Outdoor Ürünleri", "Spor & Outdoor", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateDate", "DeleteDate", "Description", "ImagePath", "Name", "Price", "Status", "StockQuantity", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 6, 22, 38, 37, 264, DateTimeKind.Local).AddTicks(8375), null, "Next Generation Smart Phone", "/images/ProductImages/smartPhone.jpg", "Smart Phone", 2000m, 1, 100, null },
                    { 2, 1, new DateTime(2024, 4, 6, 22, 38, 37, 264, DateTimeKind.Local).AddTicks(8380), null, "Wireless Headphones", "/images/ProductImages/HeadPhones.jpg", "Headphones", 100m, 1, 200, null },
                    { 3, 2, new DateTime(2024, 4, 6, 22, 38, 37, 264, DateTimeKind.Local).AddTicks(8382), null, "New Season Women's Dress", "/images/ProductImages/Dress.jpg", "Dress", 150m, 1, 150, null },
                    { 4, 2, new DateTime(2024, 4, 6, 22, 38, 37, 264, DateTimeKind.Local).AddTicks(8383), null, "Slim Fit Men's Shirt", "/images/ProductImages/Shirt.jpg", "Shirt", 80m, 1, 120, null },
                    { 5, 3, new DateTime(2024, 4, 6, 22, 38, 37, 264, DateTimeKind.Local).AddTicks(8385), null, "5-Function Kitchen Robot", "/images/ProductImages/KitchenRobot.jpg", "Kitchen Robot", 300m, 1, 80, null },
                    { 6, 3, new DateTime(2024, 4, 6, 22, 38, 37, 264, DateTimeKind.Local).AddTicks(8387), null, "Flowering Houseplant", "/images/ProductImages/HousePlant.jpg", "Houseplant", 50m, 1, 300, null },
                    { 7, 4, new DateTime(2024, 4, 6, 22, 38, 37, 264, DateTimeKind.Local).AddTicks(8388), null, "Latest Science Fiction Novel", "/images/ProductImages/ScienceFictionNovel.jpg", "Fiction Novel", 20m, 1, 500, null },
                    { 8, 4, new DateTime(2024, 4, 6, 22, 38, 37, 264, DateTimeKind.Local).AddTicks(8390), null, "Ottoman Empire History Book", "/images/ProductImages/HistoryBook.jpg", "History Book", 30m, 1, 400, null },
                    { 9, 5, new DateTime(2024, 4, 6, 22, 38, 37, 264, DateTimeKind.Local).AddTicks(8391), null, "Yoga Exercise Mat", "/images/ProductImages/YogaMat.jpg", "Yoga Mat", 25m, 1, 200, null },
                    { 10, 5, new DateTime(2024, 4, 6, 22, 38, 37, 264, DateTimeKind.Local).AddTicks(8394), null, "2-Person Camping Tent", "/images/ProductImages/CampingTent.jpg", "Camping Tent", 150m, 1, 100, null }
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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

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
                values: new object[] { "814a1009-da5d-40d6-88c5-561432df3081", new DateTime(2024, 4, 6, 22, 35, 42, 925, DateTimeKind.Local).AddTicks(9169), "AQAAAAEAACcQAAAAEAwszHHYnoRcrM+oO/1ct5kOb+EOE6+B9U6Wb+foLh2Oh6x0q/22+lFaItM0OLwOfQ==", "b0e004b5-4268-40ef-acc3-22d7fbdbb4b4" });
        }
    }
}
