using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearningCenter.Infraestructure.Migrations
{
    public partial class deleteNewAction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 20, 17, 56, 53, 493, DateTimeKind.Local).AddTicks(8283),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 20, 17, 53, 18, 407, DateTimeKind.Local).AddTicks(533));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Tutorial",
                newName: "Description");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 20, 17, 53, 18, 407, DateTimeKind.Local).AddTicks(533),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 20, 17, 56, 53, 493, DateTimeKind.Local).AddTicks(8283));
        }
    }
}
