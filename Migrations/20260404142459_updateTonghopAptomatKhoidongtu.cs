using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class updateTonghopAptomatKhoidongtu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaQuanLy",
                table: "TongHopAptomatKhoidongtu");

            migrationBuilder.DropColumn(
                name: "SoLuong",
                table: "TongHopAptomatKhoidongtu");

            migrationBuilder.RenameColumn(
                name: "NgayLap",
                table: "TongHopAptomatKhoidongtu",
                newName: "NamSanXuat");

            migrationBuilder.AlterColumn<string>(
                name: "ViTriLapDat",
                table: "TongHopKhoanBalang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TinhTrangKyThuat",
                table: "TongHopKhoanBalang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LoaiThietBi",
                table: "TongHopKhoanBalang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GhiChu",
                table: "TongHopKhoanBalang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "BitCoCap",
                table: "TongHopAptomatKhoidongtu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CapPhongNo",
                table: "TongHopAptomatKhoidongtu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CheDoLamViec",
                table: "TongHopAptomatKhoidongtu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DienApDieuKhien",
                table: "TongHopAptomatKhoidongtu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DienApSuDung",
                table: "TongHopAptomatKhoidongtu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Idm",
                table: "TongHopAptomatKhoidongtu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KheHoPhongNo",
                table: "TongHopAptomatKhoidongtu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NapMoNhanh",
                table: "TongHopAptomatKhoidongtu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoiDat",
                table: "TongHopAptomatKhoidongtu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TayDao",
                table: "TongHopAptomatKhoidongtu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThongGio",
                table: "TongHopAptomatKhoidongtu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GhiChu",
                table: "DanhMucKhoanBalang",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c249b4c2-7abd-46ff-a6b7-3f15855dce1b", "AQAAAAIAAYagAAAAEFcoBenCQGwbA8MEKPVH8o6vHo/j2jtVZ7YJJndg+usU8mey+G43+reMdcah/5q0Cg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BitCoCap",
                table: "TongHopAptomatKhoidongtu");

            migrationBuilder.DropColumn(
                name: "CapPhongNo",
                table: "TongHopAptomatKhoidongtu");

            migrationBuilder.DropColumn(
                name: "CheDoLamViec",
                table: "TongHopAptomatKhoidongtu");

            migrationBuilder.DropColumn(
                name: "DienApDieuKhien",
                table: "TongHopAptomatKhoidongtu");

            migrationBuilder.DropColumn(
                name: "DienApSuDung",
                table: "TongHopAptomatKhoidongtu");

            migrationBuilder.DropColumn(
                name: "Idm",
                table: "TongHopAptomatKhoidongtu");

            migrationBuilder.DropColumn(
                name: "KheHoPhongNo",
                table: "TongHopAptomatKhoidongtu");

            migrationBuilder.DropColumn(
                name: "NapMoNhanh",
                table: "TongHopAptomatKhoidongtu");

            migrationBuilder.DropColumn(
                name: "NoiDat",
                table: "TongHopAptomatKhoidongtu");

            migrationBuilder.DropColumn(
                name: "TayDao",
                table: "TongHopAptomatKhoidongtu");

            migrationBuilder.DropColumn(
                name: "ThongGio",
                table: "TongHopAptomatKhoidongtu");

            migrationBuilder.RenameColumn(
                name: "NamSanXuat",
                table: "TongHopAptomatKhoidongtu",
                newName: "NgayLap");

            migrationBuilder.AlterColumn<string>(
                name: "ViTriLapDat",
                table: "TongHopKhoanBalang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TinhTrangKyThuat",
                table: "TongHopKhoanBalang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LoaiThietBi",
                table: "TongHopKhoanBalang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GhiChu",
                table: "TongHopKhoanBalang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaQuanLy",
                table: "TongHopAptomatKhoidongtu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SoLuong",
                table: "TongHopAptomatKhoidongtu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "GhiChu",
                table: "DanhMucKhoanBalang",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "deb7f932-99b6-4211-9585-4a9e0293ebe9", "AQAAAAIAAYagAAAAEHvDiSLH5YInZW+VdBc7rPuQUi0DChE+Kdmu8XS/whbgd7T1x7Qy/iPpLGd5rwI9aw==" });
        }
    }
}
