using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearningCenter.Infraestructure.Migrations
{
    public partial class changeTutorialdDef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tutorials_Categories_Categoryid",
                table: "Tutorials");

            migrationBuilder.RenameColumn(
                name: "Categoryid",
                table: "Tutorials",
                newName: "categoryid");

            migrationBuilder.RenameIndex(
                name: "IX_Tutorials_Categoryid",
                table: "Tutorials",
                newName: "IX_Tutorials_categoryid");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 20, 21, 33, 25, 46, DateTimeKind.Local).AddTicks(5584),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 20, 21, 26, 1, 682, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.AddForeignKey(
                name: "FK_Tutorials_Categories_categoryid",
                table: "Tutorials",
                column: "categoryid",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tutorials_Categories_categoryid",
                table: "Tutorials");

            migrationBuilder.RenameColumn(
                name: "categoryid",
                table: "Tutorials",
                newName: "Categoryid");

            migrationBuilder.RenameIndex(
                name: "IX_Tutorials_categoryid",
                table: "Tutorials",
                newName: "IX_Tutorials_Categoryid");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 20, 21, 26, 1, 682, DateTimeKind.Local).AddTicks(1548),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 20, 21, 33, 25, 46, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.AddForeignKey(
                name: "FK_Tutorials_Categories_Categoryid",
                table: "Tutorials",
                column: "Categoryid",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
