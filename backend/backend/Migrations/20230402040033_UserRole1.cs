using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    public partial class UserRole1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Offers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 2, 4, 0, 33, 189, DateTimeKind.Utc).AddTicks(84),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 4, 2, 3, 59, 26, 165, DateTimeKind.Utc).AddTicks(6890));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Offers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 2, 3, 59, 26, 165, DateTimeKind.Utc).AddTicks(6890),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 4, 2, 4, 0, 33, 189, DateTimeKind.Utc).AddTicks(84));
        }
    }
}
