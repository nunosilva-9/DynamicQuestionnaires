using Microsoft.EntityFrameworkCore.Migrations;

namespace DynamicQuestionnaires.DAL.Migrations
{
    public partial class fixLoopQuestionsAnswer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Questions_NextQuestionId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_Questions_StartQuestionId",
                table: "Questionnaires");

            migrationBuilder.RenameColumn(
                name: "NextQuestionId",
                table: "Answer",
                newName: "QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_NextQuestionId",
                table: "Answer",
                newName: "IX_Answer_QuestionId");

            migrationBuilder.AlterColumn<int>(
                name: "StartQuestionId",
                table: "Questionnaires",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "followUpQuestion",
                table: "Answer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "prevQuestion",
                table: "Answer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Questions_QuestionId",
                table: "Answer",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaires_Questions_StartQuestionId",
                table: "Questionnaires",
                column: "StartQuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Questions_QuestionId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_Questions_StartQuestionId",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "followUpQuestion",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "prevQuestion",
                table: "Answer");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "Answer",
                newName: "NextQuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer",
                newName: "IX_Answer_NextQuestionId");

            migrationBuilder.AlterColumn<int>(
                name: "StartQuestionId",
                table: "Questionnaires",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Questions_NextQuestionId",
                table: "Answer",
                column: "NextQuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaires_Questions_StartQuestionId",
                table: "Questionnaires",
                column: "StartQuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
