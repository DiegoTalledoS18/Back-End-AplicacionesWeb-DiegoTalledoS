using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearningCenter.Infraestructure.Migrations
{
    public partial class changeTutorialName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tutorial_Categories_Categoryid",
                table: "Tutorial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tutorial",
                table: "Tutorial");

            migrationBuilder.RenameTable(
                name: "Tutorial",
                newName: "Tutorials");

            migrationBuilder.RenameIndex(
                name: "IX_Tutorial_Categoryid",
                table: "Tutorials",
                newName: "IX_Tutorials_Categoryid");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "varchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 20, 21, 26, 1, 682, DateTimeKind.Local).AddTicks(1548),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 20, 18, 7, 46, 607, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tutorials",
                table: "Tutorials",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tutorials_Categories_Categoryid",
                table: "Tutorials",
                column: "Categoryid",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tutorials_Categories_Categoryid",
                table: "Tutorials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tutorials",
                table: "Tutorials");

            migrationBuilder.RenameTable(
                name: "Tutorials",
                newName: "Tutorial");

            migrationBuilder.RenameIndex(
                name: "IX_Tutorials_Categoryid",
                table: "Tutorial",
                newName: "IX_Tutorial_Categoryid");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldMaxLength: 60)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 20, 18, 7, 46, 607, DateTimeKind.Local).AddTicks(9494),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 10, 20, 21, 26, 1, 682, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tutorial",
                table: "Tutorial",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tutorial_Categories_Categoryid",
                table: "Tutorial",
                column: "Categoryid",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
