using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.Models
{
    internal class StudentCourse
    {
        #region Relation between studentCourses
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;

        public int CourseID { get; set; }
        public Course Course { get; set; } = null!;
        #endregion
    }
}
