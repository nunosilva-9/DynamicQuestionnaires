using Microsoft.EntityFrameworkCore.Migrations;

namespace DynamicQuestionnaires.DAL.Migrations
{
    public partial class AddNextQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Questions_QuestionId",
                table: "Answer");

            migrationBuilder.DropIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer");

            migrationBuilder.AddColumn<int>(
                name: "NextQuestionId",
                table: "Answer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NextQuestionId1",
                table: "Answer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Answer_NextQuestionId",
                table: "Answer",
                column: "NextQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_NextQuestionId1",
                table: "Answer",
                column: "NextQuestionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Questions_NextQuestionId",
                table: "Answer",
                column: "NextQuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Questions_NextQuestionId1",
                table: "Answer",
                column: "NextQuestionId1",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Questions_NextQuestionId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Questions_NextQuestionId1",
                table: "Answer");

            migrationBuilder.DropIndex(
                name: "IX_Answer_NextQuestionId",
                table: "Answer");

            migrationBuilder.DropIndex(
                name: "IX_Answer_NextQuestionId1",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "NextQuestionId",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "NextQuestionId1",
                table: "Answer");

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
    }
}
