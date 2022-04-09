using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoList.Migrations
{
    public partial class StartCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "TodoList",
                newName: "Items");

            migrationBuilder.AddColumn<DateTime>(
                name: "Dates",
                table: "TodoList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dates",
                table: "TodoList");

            migrationBuilder.RenameColumn(
                name: "Items",
                table: "TodoList",
                newName: "Content");
        }
    }
}
