using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDo.Migrations
{
    /// <inheritdoc />
    public partial class addStatusProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoTasks_TaskColor_TaskColorId",
                table: "ToDoTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskColor",
                table: "TaskColor");

            migrationBuilder.RenameTable(
                name: "TaskColor",
                newName: "TaskColors");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ToDoTasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskColors",
                table: "TaskColors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoTasks_TaskColors_TaskColorId",
                table: "ToDoTasks",
                column: "TaskColorId",
                principalTable: "TaskColors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoTasks_TaskColors_TaskColorId",
                table: "ToDoTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskColors",
                table: "TaskColors");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ToDoTasks");

            migrationBuilder.RenameTable(
                name: "TaskColors",
                newName: "TaskColor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskColor",
                table: "TaskColor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoTasks_TaskColor_TaskColorId",
                table: "ToDoTasks",
                column: "TaskColorId",
                principalTable: "TaskColor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
