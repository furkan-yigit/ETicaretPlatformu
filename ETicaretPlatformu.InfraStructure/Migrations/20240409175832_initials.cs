using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretPlatformu.InfraStructure.Migrations
{
    public partial class initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4644b3f4-c1bb-42d9-8254-f28c233e3d27", new DateTime(2024, 4, 9, 20, 58, 32, 13, DateTimeKind.Local).AddTicks(1225), "AQAAAAEAACcQAAAAEFCn2OOe86fs18zMX2gzMvlRPQJNEGY5POGBy8uWgSiJb0o0n1u5BrWIRd8NjlI2bg==", "bf43021c-d0f2-43cc-acfc-c46f5182851d" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 58, 32, 14, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 58, 32, 14, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 58, 32, 14, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 58, 32, 14, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 58, 32, 14, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 58, 32, 14, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 58, 32, 14, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 58, 32, 14, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 58, 32, 14, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 58, 32, 14, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 58, 32, 14, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 58, 32, 14, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 58, 32, 14, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 58, 32, 14, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 58, 32, 14, DateTimeKind.Local).AddTicks(3558));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc7987aa-c391-4a83-bb13-7abf852fcff0", new DateTime(2024, 4, 9, 20, 32, 7, 725, DateTimeKind.Local).AddTicks(9239), "AQAAAAEAACcQAAAAEPTNuV1ZhCFinP64cKIlwScAd1uYtSdpQHREzfdmzJjJC2b42N234vKqYi6mdJ+2qQ==", "962e1e45-05e0-4edd-b918-a51e087dac8f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 4, 9, 20, 32, 7, 743, DateTimeKind.Local).AddTicks(610));
        }
    }
}
