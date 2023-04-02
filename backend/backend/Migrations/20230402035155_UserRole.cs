using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    public partial class UserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Offers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 2, 3, 51, 55, 668, DateTimeKind.Utc).AddTicks(2991),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 4, 2, 3, 36, 25, 217, DateTimeKind.Utc).AddTicks(3449));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Offers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 2, 3, 36, 25, 217, DateTimeKind.Utc).AddTicks(3449),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 4, 2, 3, 51, 55, 668, DateTimeKind.Utc).AddTicks(2991));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                unique: true);
        }
    }
}
