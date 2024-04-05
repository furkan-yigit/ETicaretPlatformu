using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaretPlatformu.InfraStructure.Migrations
{
    public partial class update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7336e7e9-5f09-4696-a50a-194a956b3a28", new DateTime(2024, 4, 5, 16, 13, 27, 17, DateTimeKind.Local).AddTicks(7694), "AQAAAAEAACcQAAAAEBOC4iC3feCQlrhejHzE4+hKDvxK9Oh0NhyolwFd57CMtnfKCH0xGBllfrw5juaxzA==", "a0d697ed-ac5b-4ecc-bc9a-21d5627bf5a0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreateDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fdbb5b4-272f-4523-a5d9-e3d5eb4572f1", new DateTime(2024, 4, 5, 15, 29, 54, 515, DateTimeKind.Local).AddTicks(644), "AQAAAAEAACcQAAAAEJxN+AiKeGWDsdQ+GASX562tCl10KC3E4UUJ/b9SBrZ3rZMcoGPKACAAhgR3Wy24xQ==", "3bad4184-a3ea-4e8d-8570-ffd12d955340" });
        }
    }
}
