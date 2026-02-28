using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Tonghopbienap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TonghopBienap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BienapId = table.Column<int>(type: "int", nullable: false),
                    PhongbanId = table.Column<int>(type: "int", nullable: false),
                    ViTriLapDat = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuPhong = table.Column<bool>(type: "bit", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TonghopBienap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TonghopBienap_DanhmucBienap_BienapId",
                        column: x => x.BienapId,
                        principalTable: "DanhmucBienap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TonghopBienap_PhongBan_PhongbanId",
                        column: x => x.PhongbanId,
                        principalTable: "PhongBan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9fa9149-54ff-4d7f-9c6d-9a96aa6cf2de", "AQAAAAIAAYagAAAAEOqaxdAqOyG5a0uDqhqVE9YUhMC60L7f0pAeNSuZtQSFzsPZUu+GMZB6DAmtuuAnww==" });

            migrationBuilder.CreateIndex(
                name: "IX_TonghopBienap_BienapId",
                table: "TonghopBienap",
                column: "BienapId");

            migrationBuilder.CreateIndex(
                name: "IX_TonghopBienap_PhongbanId",
                table: "TonghopBienap",
                column: "PhongbanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TonghopBienap");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "62e28bf7-7110-4a8b-9cc4-57320f0461a8", "AQAAAAIAAYagAAAAEC88T0F0t6hM5YMN27T6SFcjW0nGVWJb6/Drj2S9j7zaBBR6iAcuko3uhodjN7rbDw==" });
        }
    }
}
