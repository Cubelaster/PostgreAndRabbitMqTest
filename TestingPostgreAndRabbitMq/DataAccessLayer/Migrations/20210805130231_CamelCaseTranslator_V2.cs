using Core.Enums;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class CamelCaseTranslator_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TodoType>(
                name: "TodoType",
                table: "TodoItems",
                type: "\"TodoType\"",
                nullable: false,
                defaultValue: TodoType.Administrative);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TodoType",
                table: "TodoItems");
        }
    }
}
