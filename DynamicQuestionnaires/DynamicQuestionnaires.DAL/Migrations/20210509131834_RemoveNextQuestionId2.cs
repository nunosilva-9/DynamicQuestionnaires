using Microsoft.EntityFrameworkCore.Migrations;

namespace DynamicQuestionnaires.DAL.Migrations
{
    public partial class RemoveNextQuestionId2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Questions_NextQuestionId",
                table: "Answer");

            migrationBuilder.DropIndex(
                name: "IX_Answer_NextQuestionId",
                table: "Answer");

            migrationBuilder.AddColumn<int>(
                name: "AnswerId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "Answer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Questions_QuestionId",
                table: "Answer",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Questions_QuestionId",
                table: "Answer");

            migrationBuilder.DropIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "AnswerId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Answer");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_NextQuestionId",
                table: "Answer",
                column: "NextQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Questions_NextQuestionId",
                table: "Answer",
                column: "NextQuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
