using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class upateDanhmucgiacot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChieuCao",
                table: "DanhmucGiaCot");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "36bbb2bd-141f-43eb-bfea-48b191d7f494", "AQAAAAIAAYagAAAAEK+I+mWkqmP5EOYSeV4RAAPW6XVAECeoYA6DK2ZXIeIIkhMIZmNbVtC7De3BSeBmWg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ChieuCao",
                table: "DanhmucGiaCot",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fee7b087-4db3-42a7-84ae-b9c207b09ad1", "AQAAAAIAAYagAAAAEHIR9OVMqFyazBu/5417Pdzs/ChuU8CFjwKNqUg9hmZ4peGOXxdJs6jmEov584VJjQ==" });
        }
    }
}
