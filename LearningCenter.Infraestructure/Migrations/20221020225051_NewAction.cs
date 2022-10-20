using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearningCenter.Infraestructure.Migrations
{
    public partial class NewAction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescripcionAction",
                table: "Tutorial",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 20, 17, 50, 51, 206, DateTimeKind.Local).AddTicks(2938),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 20, 17, 37, 16, 196, DateTimeKind.Local).AddTicks(1728));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescripcionAction",
                table: "Tutorial");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 20, 17, 37, 16, 196, DateTimeKind.Local).AddTicks(1728),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 20, 17, 50, 51, 206, DateTimeKind.Local).AddTicks(2938));
        }
    }
}
