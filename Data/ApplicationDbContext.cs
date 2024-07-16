using Microsoft.EntityFrameworkCore;
using Student_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.Data
{
    internal class ApplicationDbContext : DbContext
    {
        #region Tables
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=Student_SysDB;
                                        Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region columns_specifications
            modelBuilder.Entity<Student>(eb => {
                eb.Property(b => b.Name).HasMaxLength(100).IsUnicode();
                eb.Property(b => b.PhoneNum).IsFixedLength().HasMaxLength(10).IsUnicode(false);

                eb.HasMany(e => e.courses).WithMany(e => e.students).UsingEntity<StudentCourse>();
            });

            modelBuilder.Entity<Course>(eb =>
            {
                eb.Property(b => b.Name).HasMaxLength(80).IsUnicode(false);
                eb.Property(b => b.Description).IsUnicode();
            });

            modelBuilder.Entity<Resource>(eb => {
                eb.Property(b => b.Name).HasMaxLength(50).IsUnicode(false);
                eb.Property(b => b.Url).IsUnicode(false);
            });

            modelBuilder.Entity<Homework>(eb =>
            {
                eb.Property(b => b.Content).IsUnicode(false);
            });

            modelBuilder.Entity<StudentCourse>(eb =>
            {
                eb.HasKey(k => new { k.StudentId, k.CourseID });
            });
            #endregion

            #region Seeding Data
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, Name = "Ahmed Medhat",PhoneNum = "0123456789",Birthday = new DateTime (2019,5,15) },
                new Student { StudentId = 2, Name = "Jane Smith"}
                );
            modelBuilder.Entity<Course>().HasData(
                new Course { CourseID = 1, Name = "EF Core", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(3), Price = 100m },
                new Course { CourseID = 2, Name = "C# Basics", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(2), Price = 50m }
            );

            modelBuilder.Entity<Resource>().HasData(
                new Resource { ResourceId = 1, Name = "EF Core Video", Url = "http://example.com", ResourceType = ResourceType.Video, CourseID = 1 },
                new Resource { ResourceId = 2, Name = "C# Basics Presentation", Url = "http://example.com", ResourceType = ResourceType.Presentation, CourseID = 2 }
            );

            modelBuilder.Entity<Homework>().HasData(
                new Homework { HomeworkId = 1, Content = "http://example.com/homework1", ContantType = ContantType.Pdf, SubmissionTime = DateTime.Now, StudentId = 1, CourseID = 1 },
                new Homework { HomeworkId = 2, Content = "http://example.com/homework2", ContantType = ContantType.Zip, SubmissionTime = DateTime.Now, StudentId = 2, CourseID = 2 }
            );

            modelBuilder.Entity<StudentCourse>().HasData(
                new StudentCourse { StudentId = 1, CourseID = 1 },
                new StudentCourse { StudentId = 1, CourseID = 2 },
                new StudentCourse { StudentId = 2, CourseID = 1 },
                new StudentCourse { StudentId = 2, CourseID = 2 }
            );
            #endregion
        }

    }
}
