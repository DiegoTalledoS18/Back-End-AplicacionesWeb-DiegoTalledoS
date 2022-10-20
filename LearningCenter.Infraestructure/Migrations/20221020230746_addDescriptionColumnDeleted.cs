using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearningCenter.Infraestructure.Migrations
{
    public partial class addDescriptionColumnDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 20, 18, 7, 46, 607, DateTimeKind.Local).AddTicks(9494),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 20, 18, 5, 50, 894, DateTimeKind.Local).AddTicks(200));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Tutorial",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 20, 18, 5, 50, 894, DateTimeKind.Local).AddTicks(200),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 20, 18, 7, 46, 607, DateTimeKind.Local).AddTicks(9494));
        }
    }
}
