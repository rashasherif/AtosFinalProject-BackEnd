using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtosExamProject.EF.Migrations
{
    /// <inheritdoc />
    public partial class answertabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "studentExamQuestionAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentExamId = table.Column<int>(type: "int", nullable: false),
                    ExamQuestionId = table.Column<int>(type: "int", nullable: false),
                    AnswerId = table.Column<int>(type: "int", nullable: false),
                    StudentExamsStudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentExamsExamId = table.Column<int>(type: "int", nullable: false),
                    examQuestionExamId = table.Column<int>(type: "int", nullable: false),
                    examQuestionQuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentExamQuestionAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentExamQuestionAnswers_StudentExams_StudentExamsStudentId_StudentExamsExamId",
                        columns: x => new { x.StudentExamsStudentId, x.StudentExamsExamId },
                        principalTable: "StudentExams",
                        principalColumns: new[] { "StudentId", "ExamId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_studentExamQuestionAnswers_examQuestions_examQuestionExamId_examQuestionQuestionId",
                        columns: x => new { x.examQuestionExamId, x.examQuestionQuestionId },
                        principalTable: "examQuestions",
                        principalColumns: new[] { "ExamId", "QuestionId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_studentExamQuestionAnswers_examQuestionExamId_examQuestionQuestionId",
                table: "studentExamQuestionAnswers",
                columns: new[] { "examQuestionExamId", "examQuestionQuestionId" });

            migrationBuilder.CreateIndex(
                name: "IX_studentExamQuestionAnswers_StudentExamsStudentId_StudentExamsExamId",
                table: "studentExamQuestionAnswers",
                columns: new[] { "StudentExamsStudentId", "StudentExamsExamId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "studentExamQuestionAnswers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
