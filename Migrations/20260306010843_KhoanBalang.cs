using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class KhoanBalang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DanhMucKhoanBalang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenThietBi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucKhoanBalang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TongHopKhoanBalang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhoanBalangId = table.Column<int>(type: "int", nullable: false),
                    DonViId = table.Column<int>(type: "int", nullable: false),
                    ViTriLapDat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    TinhTrangKyThuat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiThietBi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DuPhong = table.Column<bool>(type: "bit", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TongHopKhoanBalang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TongHopKhoanBalang_DanhMucKhoanBalang_KhoanBalangId",
                        column: x => x.KhoanBalangId,
                        principalTable: "DanhMucKhoanBalang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TongHopKhoanBalang_PhongBan_DonViId",
                        column: x => x.DonViId,
                        principalTable: "PhongBan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "deb7f932-99b6-4211-9585-4a9e0293ebe9", "AQAAAAIAAYagAAAAEHvDiSLH5YInZW+VdBc7rPuQUi0DChE+Kdmu8XS/whbgd7T1x7Qy/iPpLGd5rwI9aw==" });

            migrationBuilder.CreateIndex(
                name: "IX_TongHopKhoanBalang_DonViId",
                table: "TongHopKhoanBalang",
                column: "DonViId");

            migrationBuilder.CreateIndex(
                name: "IX_TongHopKhoanBalang_KhoanBalangId",
                table: "TongHopKhoanBalang",
                column: "KhoanBalangId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TongHopKhoanBalang");

            migrationBuilder.DropTable(
                name: "DanhMucKhoanBalang");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9fa9149-54ff-4d7f-9c6d-9a96aa6cf2de", "AQAAAAIAAYagAAAAEOqaxdAqOyG5a0uDqhqVE9YUhMC60L7f0pAeNSuZtQSFzsPZUu+GMZB6DAmtuuAnww==" });
        }
    }
}
