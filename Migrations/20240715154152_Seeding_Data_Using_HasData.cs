using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_System.Migrations
{
    /// <inheritdoc />
    public partial class Seeding_Data_Using_HasData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseID", "Description", "EndDate", "Name", "Price", "StartDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 10, 15, 18, 41, 51, 224, DateTimeKind.Local).AddTicks(3760), "EF Core", 100m, new DateTime(2024, 7, 15, 18, 41, 51, 224, DateTimeKind.Local).AddTicks(3753) },
                    { 2, null, new DateTime(2024, 9, 15, 18, 41, 51, 224, DateTimeKind.Local).AddTicks(3777), "C# Basics", 50m, new DateTime(2024, 7, 15, 18, 41, 51, 224, DateTimeKind.Local).AddTicks(3774) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Birthday", "Name", "PhoneNum", "RegisteredOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmed Medhat", "0123456789", new DateTime(2024, 7, 15, 18, 41, 51, 224, DateTimeKind.Local).AddTicks(3416) },
                    { 2, null, "Jane Smith", null, new DateTime(2024, 7, 15, 18, 41, 51, 224, DateTimeKind.Local).AddTicks(3498) }
                });

            migrationBuilder.InsertData(
                table: "Homeworks",
                columns: new[] { "HomeworkId", "ContantType", "Content", "CourseID", "StudentId", "SubmissionTime" },
                values: new object[,]
                {
                    { 1, 1, "http://example.com/homework1", 1, 1, new DateTime(2024, 7, 15, 18, 41, 51, 224, DateTimeKind.Local).AddTicks(3859) },
                    { 2, 2, "http://example.com/homework2", 2, 2, new DateTime(2024, 7, 15, 18, 41, 51, 224, DateTimeKind.Local).AddTicks(3868) }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ResourceId", "CourseID", "Name", "ResourceType", "Url" },
                values: new object[,]
                {
                    { 1, 1, "EF Core Video", 0, "http://example.com" },
                    { 2, 2, "C# Basics Presentation", 1, "http://example.com" }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseID", "StudentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Homeworks",
                keyColumn: "HomeworkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Homeworks",
                keyColumn: "HomeworkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ResourceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseID", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseID", "StudentId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseID", "StudentId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseID", "StudentId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);
        }
    }
}
