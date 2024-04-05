using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretPlatformu.InfraStructure.Migrations
{
    public partial class update4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0215d83b-9eb3-4d31-a948-088789420618", new DateTime(2024, 4, 5, 16, 15, 30, 471, DateTimeKind.Local).AddTicks(1795), "AQAAAAEAACcQAAAAENGEhQXfnUlDNi2E66cOK42VQTKhOeK3hk1uexnhjm1QqMrq8Lnj2pRNwnQMrbZ2UA==", "a6800c2c-690e-47d3-a883-0762c90dc5ab" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7336e7e9-5f09-4696-a50a-194a956b3a28", new DateTime(2024, 4, 5, 16, 13, 27, 17, DateTimeKind.Local).AddTicks(7694), "AQAAAAEAACcQAAAAEBOC4iC3feCQlrhejHzE4+hKDvxK9Oh0NhyolwFd57CMtnfKCH0xGBllfrw5juaxzA==", "a0d697ed-ac5b-4ecc-bc9a-21d5627bf5a0" });
        }
    }
}
