using Microsoft.EntityFrameworkCore.Migrations;

namespace DynamicQuestionnaires.DAL.Migrations
{
    public partial class addStartQuestionId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_Questions_StartQuestionId",
                table: "Questionnaires");

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
                name: "FK_Questionnaires_Questions_StartQuestionId",
                table: "Questionnaires",
                column: "StartQuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_Questions_StartQuestionId",
                table: "Questionnaires");

            migrationBuilder.AlterColumn<int>(
                name: "StartQuestionId",
                table: "Questionnaires",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaires_Questions_StartQuestionId",
                table: "Questionnaires",
                column: "StartQuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
