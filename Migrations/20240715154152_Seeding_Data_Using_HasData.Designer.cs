﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Student_System.Data;

#nullable disable

namespace Student_System.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240715154152_Seeding_Data_Using_HasData")]
    partial class Seeding_Data_Using_HasData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Student_System.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"));

                    b.Property<string>("Description")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseID = 1,
                            EndDate = new DateTime(2024, 10, 15, 18, 41, 51, 224, DateTimeKind.Local).AddTicks(3760),
                            Name = "EF Core",
                            Price = 100m,
                            StartDate = new DateTime(2024, 7, 15, 18, 41, 51, 224, DateTimeKind.Local).AddTicks(3753)
                        },
                        new
                        {
                            CourseID = 2,
                            EndDate = new DateTime(2024, 9, 15, 18, 41, 51, 224, DateTimeKind.Local).AddTicks(3777),
                            Name = "C# Basics",
                            Price = 50m,
                            StartDate = new DateTime(2024, 7, 15, 18, 41, 51, 224, DateTimeKind.Local).AddTicks(3774)
                        });
                });

            modelBuilder.Entity("Student_System.Models.Homework", b =>
                {
                    b.Property<int>("HomeworkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HomeworkId"));

                    b.Property<int>("ContantType")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmissionTime")
                        .HasColumnType("datetime2");

                    b.HasKey("HomeworkId");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentId");

                    b.ToTable("Homeworks");

                    b.HasData(
                        new
                        {
                            HomeworkId = 1,
                            ContantType = 1,
                            Content = "http://example.com/homework1",
                            CourseID = 1,
                            StudentId = 1,
                            SubmissionTime = new DateTime(2024, 7, 15, 18, 41, 51, 224, DateTimeKind.Local).AddTicks(3859)
                        },
                        new
                        {
                            HomeworkId = 2,
                            ContantType = 2,
                            Content = "http://example.com/homework2",
                            CourseID = 2,
                            StudentId = 2,
                            SubmissionTime = new DateTime(2024, 7, 15, 18, 41, 51, 224, DateTimeKind.Local).AddTicks(3868)
                        });
                });

            modelBuilder.Entity("Student_System.Models.Resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResourceId"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("ResourceType")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("ResourceId");

                    b.HasIndex("CourseID");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            ResourceId = 1,
                            CourseID = 1,
                            Name = "EF Core Video",
                            ResourceType = 0,
                            Url = "http://example.com"
                        },
                        new
                        {
                            ResourceId = 2,
                            CourseID = 2,
                            Name = "C# Basics Presentation",
                            ResourceType = 1,
                            Url = "http://example.com"
                        });
                });

            modelBuilder.Entity("Student_System.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNum")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<DateTime>("RegisteredOn")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Birthday = new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ahmed Medhat",
                            PhoneNum = "0123456789",
                            RegisteredOn = new DateTime(2024, 7, 15, 18, 41, 51, 224, DateTimeKind.Local).AddTicks(3416)
                        },
                        new
                        {
                            StudentId = 2,
                            Name = "Jane Smith",
                            RegisteredOn = new DateTime(2024, 7, 15, 18, 41, 51, 224, DateTimeKind.Local).AddTicks(3498)
                        });
                });

            modelBuilder.Entity("Student_System.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseID");

                    b.HasIndex("CourseID");

                    b.ToTable("StudentCourses");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            CourseID = 1
                        },
                        new
                        {
                            StudentId = 1,
                            CourseID = 2
                        },
                        new
                        {
                            StudentId = 2,
                            CourseID = 1
                        },
                        new
                        {
                            StudentId = 2,
                            CourseID = 2
                        });
                });

            modelBuilder.Entity("Student_System.Models.Homework", b =>
                {
                    b.HasOne("Student_System.Models.Course", "Course")
                        .WithMany("homework")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Student_System.Models.Student", "Student")
                        .WithMany("homework")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Student_System.Models.Resource", b =>
                {
                    b.HasOne("Student_System.Models.Course", "Course")
                        .WithMany("resources")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Student_System.Models.StudentCourse", b =>
                {
                    b.HasOne("Student_System.Models.Course", "Course")
                        .WithMany("studentCourses")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Student_System.Models.Student", "Student")
                        .WithMany("studentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Student_System.Models.Course", b =>
                {
                    b.Navigation("homework");

                    b.Navigation("resources");

                    b.Navigation("studentCourses");
                });

            modelBuilder.Entity("Student_System.Models.Student", b =>
                {
                    b.Navigation("homework");

                    b.Navigation("studentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
