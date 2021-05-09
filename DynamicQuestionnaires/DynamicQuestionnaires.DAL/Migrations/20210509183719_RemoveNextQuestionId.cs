using Microsoft.EntityFrameworkCore.Migrations;

namespace DynamicQuestionnaires.DAL.Migrations
{
    public partial class RemoveNextQuestionId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Questions_NextQuestionId",
                table: "Answer");

            migrationBuilder.DropIndex(
                name: "IX_Answer_NextQuestionId",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "NextQuestionId",
                table: "Answer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NextQuestionId",
                table: "Answer",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
