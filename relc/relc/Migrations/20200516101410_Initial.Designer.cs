﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using relc.Data;

namespace relc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200516101410_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("relc.Models.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<short>("GradingScoreMax")
                        .HasColumnType("smallint");

                    b.Property<short>("GradingScoreMin")
                        .HasColumnType("smallint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsEditable")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.Property<int>("RoundingMethod")
                        .HasColumnType("int");

                    b.Property<short>("ScoreMax")
                        .HasColumnType("smallint");

                    b.Property<short>("TimeLimitSeconds")
                        .HasColumnType("smallint");

                    b.HasKey("ExamId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("relc.Models.ExamAttempt", b =>
                {
                    b.Property<int>("ExamAttemptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<short>("Grade")
                        .HasColumnType("smallint");

                    b.Property<int>("LoginId")
                        .HasColumnType("int");

                    b.Property<short>("Score")
                        .HasColumnType("smallint");

                    b.Property<short>("TimeTaken")
                        .HasColumnType("smallint");

                    b.HasKey("ExamAttemptId");

                    b.HasIndex("ExamId");

                    b.HasIndex("LoginId");

                    b.ToTable("ExamAttempts");
                });

            modelBuilder.Entity("relc.Models.ExamAttemptAnswer", b =>
                {
                    b.Property<int>("ExamAttemptAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ExamAttemptId")
                        .HasColumnType("int");

                    b.HasKey("ExamAttemptAnswerId");

                    b.HasIndex("ExamAttemptId");

                    b.ToTable("ExamAttemptAnswers");
                });

            modelBuilder.Entity("relc.Models.ExamQuestion", b =>
                {
                    b.Property<int>("ExamQuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("AlwaysAppear")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<bool>("IsOptional")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Options")
                        .HasColumnType("varchar(1000) CHARACTER SET utf8mb4")
                        .HasMaxLength(1000);

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.Property<short>("Score")
                        .HasColumnType("smallint");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ExamQuestionId");

                    b.HasIndex("ExamId");

                    b.ToTable("ExamQuestions");
                });

            modelBuilder.Entity("relc.Models.Login", b =>
                {
                    b.Property<int>("LoginId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NameFirst")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("NameLast")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.HasKey("LoginId");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("relc.Models.ExamAttempt", b =>
                {
                    b.HasOne("relc.Models.Exam", "Exam")
                        .WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("relc.Models.Login", "Login")
                        .WithMany("ExamsAttempts")
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("relc.Models.ExamAttemptAnswer", b =>
                {
                    b.HasOne("relc.Models.ExamAttempt", "ExamAttempt")
                        .WithMany("Answers")
                        .HasForeignKey("ExamAttemptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("relc.Models.ExamQuestion", b =>
                {
                    b.HasOne("relc.Models.Exam", "Exam")
                        .WithMany("Questions")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
