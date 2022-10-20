using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearningCenter.Infraestructure.Migrations
{
    public partial class newname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 20, 18, 0, 34, 833, DateTimeKind.Local).AddTicks(2332),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 20, 17, 56, 53, 493, DateTimeKind.Local).AddTicks(8283));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 20, 17, 56, 53, 493, DateTimeKind.Local).AddTicks(8283),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 20, 18, 0, 34, 833, DateTimeKind.Local).AddTicks(2332));
        }
    }
}
