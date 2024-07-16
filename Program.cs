using Student_System.Data;
using Student_System.Models;

namespace Student_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            #region Seeding Data
            //// Seed Students
            //var student = new List<Student>();
            //student.Add(new Student{
            //    Name = "John Doe",
            //    PhoneNum = "1234567890",
            //    RegisteredOn = DateTime.Now,
            //    Birthday = new DateTime(1990, 1, 1)
            //});
            //student.Add(new Student
            //{
            //    Name = "Jane Smith",
            //    PhoneNum = "0987654321",
            //    RegisteredOn = DateTime.Now,
            //    Birthday = new DateTime(1992, 2, 2)
            //});

            //context.Students.AddRange(student);

            //// Seed Courses
            //var course1 = new Course
            //{
            //    Name = "EF Core",
            //    Description = "Learn Entity Framework Core",
            //    StartDate = DateTime.Now,
            //    EndDate = DateTime.Now.AddMonths(3),
            //    Price = 100m
            //};
            //var course2 = new Course
            //{
            //    Name = "C# Basics",
            //    Description = "Learn the basics of C#",
            //    StartDate = DateTime.Now,
            //    EndDate = DateTime.Now.AddMonths(2),
            //    Price = 50m
            //};

            //context.Courses.Add(course1);
            //context.Courses.Add(course2);

            //// Seed Resources
            //var resource1 = new Resource
            //{
            //    Name = "EF Core Video",
            //    Url = "http://example.com/efcorevideo",
            //    ResourceType = ResourceType.Video,
            //    Course = course1
            //};
            //var resource2 = new Resource
            //{
            //    Name = "C# Basics Presentation",
            //    Url = "http://example.com/csharpbasics",
            //    ResourceType = ResourceType.Presentation,
            //    Course = course2
            //};

            //context.Resources.Add(resource1);
            //context.Resources.Add(resource2);

            //// Seed Homeworks
            //var homework1 = new Homework
            //{
            //    Content = "http://example.com/homework1",
            //    ContantType = ContantType.Pdf,
            //    SubmissionTime = DateTime.Now,
            //    Student = student[0],
            //    Course = course1
            //};
            //var homework2 = new Homework
            //{
            //    Content = "http://example.com/homework2",
            //    ContantType = ContantType.Zip,
            //    SubmissionTime = DateTime.Now,
            //    Student = student[1],
            //    Course = course2
            //};

            //context.Homeworks.Add(homework1);
            //context.Homeworks.Add(homework2);

            //// Seed StudentCourse (many-to-many relationships)
            //var studentCourse1 = new StudentCourse
            //{
            //    Student = student[0],
            //    Course = course1
            //};
            //var studentCourse2 = new StudentCourse
            //{
            //    Student = student[1],
            //    Course = course2
            //};

            //context.StudentCourses.Add(studentCourse1);
            //context.StudentCourses.Add(studentCourse2);

            //// Save all changes to the database
            //context.SaveChanges();
            #endregion

            #region console application that reads information about courses and students and store it
            int chooice;
            var student = new Student();
            var course = new Course();
            var running = true;
            while (running)
            {
                Console.WriteLine(@"Please Chooise an option:
                1 - Add New Student
                2 - Add New Course
                3 - Quit");
                chooice = int.Parse(Console.ReadLine());
                switch (chooice)
                {
                        case 1:
                        student = new Student();
                        Console.WriteLine("Name = ");
                        student.Name = Console.ReadLine();
                        context.Students.Add(student);
                        context.SaveChanges();
                        break;
                        case 2:
                        course = new Course();
                        course.StartDate = DateTime.Now;
                        course.EndDate = DateTime.Now.AddMonths(5);
                        Console.Write("Name = ");
                        course.Name = Console.ReadLine();
                        Console.Write("Price = ");
                        course.Price = decimal.Parse(Console.ReadLine());
                        context.Courses.Add(course);
                        context.SaveChanges(true);
                        break;
                        case 3:
                        running = false;
                        break;
                }
            }
            #endregion
        }
    }
}
