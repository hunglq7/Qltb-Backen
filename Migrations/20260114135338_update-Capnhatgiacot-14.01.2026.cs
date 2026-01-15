using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class updateCapnhatgiacot14012026 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoLuongDuPhong",
                table: "CapNhatGiaCot");

            migrationBuilder.DropColumn(
                name: "SoLuongHong",
                table: "CapNhatGiaCot");

            migrationBuilder.DropColumn(
                name: "SoLuongHuyDong",
                table: "CapNhatGiaCot");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "62e28bf7-7110-4a8b-9cc4-57320f0461a8", "AQAAAAIAAYagAAAAEC88T0F0t6hM5YMN27T6SFcjW0nGVWJb6/Drj2S9j7zaBBR6iAcuko3uhodjN7rbDw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SoLuongDuPhong",
                table: "CapNhatGiaCot",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoLuongHong",
                table: "CapNhatGiaCot",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoLuongHuyDong",
                table: "CapNhatGiaCot",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd497311-595a-4cb9-9bd0-a4df3355fef1", "AQAAAAIAAYagAAAAEBobi1/lTG+Dabo1e7Ge5SUw6napme+dyKaL0vF+SRah5ia5RyeMEZi1eSMh+PVC0Q==" });
        }
    }
}
