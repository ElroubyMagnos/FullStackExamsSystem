﻿// <auto-generated />
using System;
using ESiteCore.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityBaseEE.Migrations
{
    [DbContext(typeof(gzera))]
    [Migration("20240525150638_drsamir3")]
    partial class drsamir3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityBaseEE.Classes.Answer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("Right")
                        .HasColumnType("bit");

                    b.Property<bool>("ischoose")
                        .HasColumnType("bit");

                    b.Property<int>("quesid")
                        .HasColumnType("int");

                    b.Property<string>("selectedanswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("student")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("EntityBaseEE.Classes.AnswerOfEssay", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<string>("answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ismarked")
                        .HasColumnType("bit");

                    b.Property<int>("quesid")
                        .HasColumnType("int");

                    b.Property<int>("student")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("AnswersOfEssay");
                });

            modelBuilder.Entity("EntityBaseEE.Classes.Bank.BankChooseQues", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("FirstAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FourthAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerID")
                        .HasColumnType("int");

                    b.Property<int>("RightAnswer")
                        .HasColumnType("int");

                    b.Property<string>("SecondAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.Property<string>("ThirdAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ChooseBank");
                });

            modelBuilder.Entity("EntityBaseEE.Classes.Bank.BankEssayQues", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("OwnerID")
                        .HasColumnType("int");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("EssayBank");
                });

            modelBuilder.Entity("EntityBaseEE.Classes.Bank.BankRightWrongQues", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("OwnerID")
                        .HasColumnType("int");

                    b.Property<bool>("RightAnswer")
                        .HasColumnType("bit");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("RightWrongBank");
                });

            modelBuilder.Entity("EntityBaseEE.Classes.ChooseQues", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("ExamID")
                        .HasColumnType("int");

                    b.Property<string>("FirstAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FourthAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int>("RightAnswer")
                        .HasColumnType("int");

                    b.Property<string>("SecondAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ChooseQuestions");
                });

            modelBuilder.Entity("EntityBaseEE.Classes.EssayQues", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("ExamID")
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("EssayQuestions");
                });

            modelBuilder.Entity("EntityBaseEE.Classes.ExamMain", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CloseTime")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("CoverImage")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OpenTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Shuffle")
                        .HasColumnType("bit");

                    b.Property<int>("Specality")
                        .HasColumnType("int");

                    b.Property<int>("Subject")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearNumber")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("EntityBaseEE.Classes.ExamProgress", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("Corrected")
                        .HasColumnType("bit");

                    b.Property<int>("ExamID")
                        .HasColumnType("int");

                    b.Property<int>("GottenMarks")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("TotalMarks")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ExamProgresses");
                });

            modelBuilder.Entity("EntityBaseEE.Classes.RightWrongQues", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("ExamID")
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<bool>("RightAnswer")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("RightWrongQuestions");
                });

            modelBuilder.Entity("EntityBaseEE.Classes.SiteSettings", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("StudentAccountExpirationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("SiteSettings");
                });

            modelBuilder.Entity("EntityBaseEE.Classes.Subject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("GradeYear")
                        .HasColumnType("int");

                    b.Property<int>("Specality")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("EntityBaseEE.Classes.UserCont", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("CanCreateAccounts")
                        .HasColumnType("bit");

                    b.Property<bool>("CanDeleteAllExams")
                        .HasColumnType("bit");

                    b.Property<bool>("CanEditAllStudentsData")
                        .HasColumnType("bit");

                    b.Property<bool>("CanEnterCore")
                        .HasColumnType("bit");

                    b.Property<bool>("CanEnterExamsWindow")
                        .HasColumnType("bit");

                    b.Property<bool>("CanEnterQuestionsBank")
                        .HasColumnType("bit");

                    b.Property<bool>("CanEnterSettings")
                        .HasColumnType("bit");

                    b.Property<bool>("CanEnterStudentWindow")
                        .HasColumnType("bit");

                    b.Property<bool>("CanSignIn")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasMaxLength(200)
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("UserConts");
                });

            modelBuilder.Entity("ESiteCore.Server.Classes.GradeOfYear", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("IDOfGrade")
                        .HasColumnType("int");

                    b.Property<int>("TypeOfLearnID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("GradeOfYears");
                });

            modelBuilder.Entity("ESiteCore.Server.Classes.GroupSign", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("GradeYear")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("GroupSigns");
                });

            modelBuilder.Entity("ESiteCore.Server.Classes.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GradeNumber")
                        .HasColumnType("int");

                    b.Property<int>("Group")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Speciality")
                        .HasColumnType("int");

                    b.Property<int>("UniqueNumber")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ESiteCore.Server.Classes.TypeOfLearn", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NameOf")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("TypeOfLearns");
                });

            modelBuilder.Entity("ESiteCore.Server.Classes.YearWithNumber", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("TypeOfGradeID")
                        .HasColumnType("int");

                    b.Property<int>("YearNumber")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("YearWithNumbers");
                });
#pragma warning restore 612, 618
        }
    }
}
