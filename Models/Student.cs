using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.Models
{
    internal class Student
    {
        #region properties
        public int StudentId { get; set; }
        public string Name { get; set; } = null!;
        public string? PhoneNum { get; set; }
        public DateTime RegisteredOn { get; set; } = DateTime.Now;
        public DateTime? Birthday { get; set; }
        #endregion

        #region Relation between studentCourses
        public List<StudentCourse> studentCourses { get; set; } = [];
        public List<Course> courses { get; set; } = [];
        #endregion

        #region Relation between st HW
        public ICollection<Homework> homework { get; set; } = new List<Homework>();
        #endregion
    }
}
