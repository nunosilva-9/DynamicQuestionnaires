using Microsoft.EntityFrameworkCore.Migrations;

namespace DynamicQuestionnaires.DAL.Migrations
{
    public partial class RemoveNextQuestionId1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Answer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "Answer",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
