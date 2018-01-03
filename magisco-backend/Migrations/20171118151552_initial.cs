using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Magisco.Profile.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnswerSets",
                columns: table => new
                {
                    AnswerSetID = table.Column<Guid>(nullable: false),
                    Completed = table.Column<bool>(nullable: false),
                    TimeCompleted = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerSets", x => x.AnswerSetID);
                });

            migrationBuilder.CreateTable(
                name: "QuestionSets",
                columns: table => new
                {
                    QuestionSetID = table.Column<Guid>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    QuestionSetFor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionSets", x => x.QuestionSetID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "AnswerSets");

            migrationBuilder.DropTable(
                name: "QuestionSets");
        }
    }
}
