using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretPlatformu.InfraStructure.Migrations
{
    public partial class descriptionNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7efa8dec-9faa-4122-8331-8cec40533f47", new DateTime(2024, 4, 7, 16, 26, 35, 550, DateTimeKind.Local).AddTicks(8282), "AQAAAAEAACcQAAAAEPDKBSPeVh0FAjA9hicGOlchbfY2Esd6WInDG96tYr03Lhp2URlL4QmLIORP775J8w==", "a2f954cb-b0e0-47f2-880f-bd2d38eaafb7" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 16, 26, 35, 559, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 16, 26, 35, 559, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 16, 26, 35, 559, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 16, 26, 35, 559, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 16, 26, 35, 559, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 16, 26, 35, 559, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 16, 26, 35, 559, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 16, 26, 35, 559, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 16, 26, 35, 559, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 16, 26, 35, 559, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 16, 26, 35, 559, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 16, 26, 35, 559, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 16, 26, 35, 559, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 16, 26, 35, 559, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 16, 26, 35, 559, DateTimeKind.Local).AddTicks(1543));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 4, 7, 14, 18, 34, 258, DateTimeKind.Local).AddTicks(7933));
        }
    }
}
