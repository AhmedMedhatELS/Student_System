using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.Models
{
    internal class Course
    {
        #region properties
        public int CourseID { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set;}
        public decimal Price {  get; set; }
        #endregion

        #region Relation between studentCourses
        public List<StudentCourse> studentCourses { get; set; } = [];
        public List<Student> students { get; set; } = [];
        #endregion

        #region Relation between Course and Resource
        public ICollection<Resource> resources { get; set; } = new List<Resource>();
        #endregion

        #region Relation between Course and Homework
        public ICollection<Homework> homework { get; set; } = new List<Homework>();
        #endregion
    }
}
