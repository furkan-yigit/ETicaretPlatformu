using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretPlatformu.InfraStructure.Migrations
{
    public partial class inits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderStatus",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92fa0c85-2ed6-430c-b817-b3d7585ec9c2", new DateTime(2024, 4, 14, 17, 38, 35, 429, DateTimeKind.Local).AddTicks(1645), "AQAAAAEAACcQAAAAEOAYCrwxUQdrm9d+w88TZEEvC6KhY482ScsMd/y/IUniJN/E61BWfEVWFQVqO5krJQ==", "4630f50e-1072-43a0-ad54-6bfe59093d12" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 38, 35, 430, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 38, 35, 430, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 38, 35, 430, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 38, 35, 430, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 38, 35, 430, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 38, 35, 430, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 38, 35, 430, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 38, 35, 430, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 38, 35, 430, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 38, 35, 430, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 38, 35, 430, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 38, 35, 430, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 38, 35, 430, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 38, 35, 430, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 38, 35, 430, DateTimeKind.Local).AddTicks(3940));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderStatus",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5386c9a7-9669-4112-bff9-5e05fffceb38", new DateTime(2024, 4, 14, 17, 18, 15, 767, DateTimeKind.Local).AddTicks(491), "AQAAAAEAACcQAAAAEODcBLhW66Fj67x8ylIcmbxPBVmweQ3Ivm/leuOg3we93zVuw3xP+pQ9H6u7bqr9Ew==", "632005b0-9972-41c7-a17f-e58d8dc6fd71" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 18, 15, 768, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 18, 15, 768, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 18, 15, 768, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 18, 15, 768, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 18, 15, 768, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 18, 15, 768, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 18, 15, 768, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 18, 15, 768, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 18, 15, 768, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 18, 15, 768, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 18, 15, 768, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 18, 15, 768, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 18, 15, 768, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 18, 15, 768, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 4, 14, 17, 18, 15, 768, DateTimeKind.Local).AddTicks(2620));
        }
    }
}
