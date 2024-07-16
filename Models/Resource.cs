using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.Models
{
    internal class Resource
    {
        #region properties
        public int ResourceId { get; set; }
        public string Name { get; set; } = null!;
        public string? Url {  get; set; }
        public ResourceType ResourceType { get; set; }
        #endregion

        #region Relation between Course and Resource
        public int CourseID { get; set; }
        public Course Course { get; set; }
        #endregion
    }

    enum ResourceType
    {
        Video,
        Presentation,
        Document,
        Other
    }
}
