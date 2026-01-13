using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Capnhatgiacotupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ViTriSuDung",
                table: "CapNhatGiaCot",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd497311-595a-4cb9-9bd0-a4df3355fef1", "AQAAAAIAAYagAAAAEBobi1/lTG+Dabo1e7Ge5SUw6napme+dyKaL0vF+SRah5ia5RyeMEZi1eSMh+PVC0Q==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ViTriSuDung",
                table: "CapNhatGiaCot");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "36bbb2bd-141f-43eb-bfea-48b191d7f494", "AQAAAAIAAYagAAAAEK+I+mWkqmP5EOYSeV4RAAPW6XVAECeoYA6DK2ZXIeIIkhMIZmNbVtC7De3BSeBmWg==" });
        }
    }
}
