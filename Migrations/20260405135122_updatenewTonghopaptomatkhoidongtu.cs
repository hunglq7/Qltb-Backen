using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class updatenewTonghopaptomatkhoidongtu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "TayDao",
                table: "TongHopAptomatKhoidongtu",
                type: "bit",
                maxLength: 50,
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "NoiDat",
                table: "TongHopAptomatKhoidongtu",
                type: "bit",
                maxLength: 50,
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "NapMoNhanh",
                table: "TongHopAptomatKhoidongtu",
                type: "bit",
                maxLength: 50,
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "KheHoPhongNo",
                table: "TongHopAptomatKhoidongtu",
                type: "bit",
                maxLength: 50,
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6cf00eaf-8911-4b5b-a13c-6b05221fd79d", "AQAAAAIAAYagAAAAEGLt4SU6njKxAlw2kk0EJ5v0OI61P2omIO58xvdtvtDCc4HNFBQJY/cIrSkXLEuW6A==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TayDao",
                table: "TongHopAptomatKhoidongtu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "NoiDat",
                table: "TongHopAptomatKhoidongtu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "NapMoNhanh",
                table: "TongHopAptomatKhoidongtu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "KheHoPhongNo",
                table: "TongHopAptomatKhoidongtu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c249b4c2-7abd-46ff-a6b7-3f15855dce1b", "AQAAAAIAAYagAAAAEFcoBenCQGwbA8MEKPVH8o6vHo/j2jtVZ7YJJndg+usU8mey+G43+reMdcah/5q0Cg==" });
        }
    }
}
