using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearningCenter.Infraestructure.Migrations
{
    public partial class newcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescripcionAlt",
                table: "Tutorial",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 20, 18, 2, 57, 326, DateTimeKind.Local).AddTicks(7136),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 20, 18, 0, 34, 833, DateTimeKind.Local).AddTicks(2332));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescripcionAlt",
                table: "Tutorial");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 20, 18, 0, 34, 833, DateTimeKind.Local).AddTicks(2332),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 20, 18, 2, 57, 326, DateTimeKind.Local).AddTicks(7136));
        }
    }
}
