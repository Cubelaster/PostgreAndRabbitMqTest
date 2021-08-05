using Core.Enums;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class CamelCaseTranslator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TodoType",
                table: "TodoItems");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:TodoType", "Administrative,Technical,HR,Something")
                .OldAnnotation("Npgsql:Enum:todo_type", "administrative,technical,hr,something");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:todo_type", "administrative,technical,hr,something")
                .OldAnnotation("Npgsql:Enum:TodoType", "Administrative,Technical,HR,Something");

            migrationBuilder.AddColumn<TodoType>(
                name: "TodoType",
                table: "TodoItems",
                type: "todo_type",
                nullable: false,
                defaultValue: TodoType.Administrative);
        }
    }
}
