﻿// <auto-generated />
using Magisco.Profile.Infrastructure;
using Magisco.Profile.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Magisco.Profile.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Magisco.Profile.Models.Answer", b =>
                {
                    b.Property<Guid>("AnswerID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AnswerSetID");

                    b.Property<int>("AnswerType");

                    b.Property<DateTime>("TimeAnswered");

                    b.HasKey("AnswerID");

                    b.HasIndex("AnswerSetID");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Magisco.Profile.Models.AnswerSet", b =>
                {
                    b.Property<Guid>("AnswerSetID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Completed");

                    b.Property<DateTime>("TimeCompleted");

                    b.HasKey("AnswerSetID");

                    b.ToTable("AnswerSets");
                });

            modelBuilder.Entity("Magisco.Profile.Models.Question", b =>
                {
                    b.Property<Guid>("QuestionID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("QuestionFor");

                    b.Property<string>("QuestionPhrased");

                    b.Property<Guid?>("QuestionSetID");

                    b.HasKey("QuestionID");

                    b.HasIndex("QuestionSetID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Magisco.Profile.Models.QuestionSet", b =>
                {
                    b.Property<Guid>("QuestionSetID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<int>("QuestionSetFor");

                    b.HasKey("QuestionSetID");

                    b.ToTable("QuestionSets");
                });

            modelBuilder.Entity("Magisco.Profile.Models.Answer", b =>
                {
                    b.HasOne("Magisco.Profile.Models.AnswerSet")
                        .WithMany("Answers")
                        .HasForeignKey("AnswerSetID");
                });

            modelBuilder.Entity("Magisco.Profile.Models.Question", b =>
                {
                    b.HasOne("Magisco.Profile.Models.QuestionSet")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionSetID");
                });
#pragma warning restore 612, 618
        }
    }
}