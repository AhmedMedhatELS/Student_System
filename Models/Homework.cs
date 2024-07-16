using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.Models
{
    internal class Homework
    {
        #region properties
        public int HomeworkId {  get; set; }
        public string Content { get; set; } = null!;
        public ContantType ContantType { get; set; }
        public DateTime SubmissionTime { get; set; }
        #endregion

        #region Relation between st HW
        public int StudentId { get; set; }
        public Student Student { get; set; }
        #endregion

        #region Relation between Course and Homework
        public int CourseID { get; set; }
        public Course Course { get; set; }
        #endregion
    }
    enum ContantType
    {
        Application,
        Pdf,
        Zip
    }
}
