using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Magisco.Profile.Migrations
{
    public partial class updated_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AnswerID = table.Column<Guid>(nullable: false),
                    AnswerSetID = table.Column<Guid>(nullable: true),
                    AnswerType = table.Column<int>(nullable: false),
                    TimeAnswered = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.AnswerID);
                    table.ForeignKey(
                        name: "FK_Answers_AnswerSets_AnswerSetID",
                        column: x => x.AnswerSetID,
                        principalTable: "AnswerSets",
                        principalColumn: "AnswerSetID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionID = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    QuestionFor = table.Column<int>(nullable: false),
                    QuestionPhrased = table.Column<string>(nullable: true),
                    QuestionSetID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionID);
                    table.ForeignKey(
                        name: "FK_Questions_QuestionSets_QuestionSetID",
                        column: x => x.QuestionSetID,
                        principalTable: "QuestionSets",
                        principalColumn: "QuestionSetID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_AnswerSetID",
                table: "Answers",
                column: "AnswerSetID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionSetID",
                table: "Questions",
                column: "QuestionSetID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    AnswerID = table.Column<Guid>(nullable: false),
                    AnswerSetID = table.Column<Guid>(nullable: true),
                    AnswerType = table.Column<int>(nullable: false),
                    TimeAnswered = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.AnswerID);
                    table.ForeignKey(
                        name: "FK_Answer_AnswerSets_AnswerSetID",
                        column: x => x.AnswerSetID,
                        principalTable: "AnswerSets",
                        principalColumn: "AnswerSetID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    QuestionID = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    QuestionFor = table.Column<int>(nullable: false),
                    QuestionPhrased = table.Column<string>(nullable: true),
                    QuestionSetID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.QuestionID);
                    table.ForeignKey(
                        name: "FK_Question_QuestionSets_QuestionSetID",
                        column: x => x.QuestionSetID,
                        principalTable: "QuestionSets",
                        principalColumn: "QuestionSetID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_AnswerSetID",
                table: "Answer",
                column: "AnswerSetID");

            migrationBuilder.CreateIndex(
                name: "IX_Question_QuestionSetID",
                table: "Question",
                column: "QuestionSetID");
        }
    }
}
