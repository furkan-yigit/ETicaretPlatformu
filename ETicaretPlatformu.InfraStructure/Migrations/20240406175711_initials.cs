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
                values: new object[] { "3689a026-1606-4d4b-9d75-f6a0e99ae2fc", new DateTime(2024, 4, 6, 20, 57, 10, 696, DateTimeKind.Local).AddTicks(4516), "AQAAAAEAACcQAAAAEOK4qzZtteRV7hfQT7IG4OBKGEExr98+W/jgefzLPQ1ASZkRVx2IP0bQCwXSUrcpbQ==", "960a34d8-11e1-426e-9779-f89aba502901" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6b0bf35-7a62-4f9b-86b7-5421c66c5fdb", new DateTime(2024, 4, 5, 22, 13, 42, 30, DateTimeKind.Local).AddTicks(2021), "AQAAAAEAACcQAAAAEAJZcaFv0uM5Mgw2LUB+yKZ9/hZSmEiaaNnUpC/0+rFVXevIeP1CDGJIqK0Ae7NbMA==", "6be37442-4eca-409c-acee-3245195b76f0" });
        }
    }
}
