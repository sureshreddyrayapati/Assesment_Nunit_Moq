using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Students
    {
        public int RollNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOb { get; set; }

    }
    public class Teachers
    {
        public int Tid { get; set; }
        public string TeacherName { get; set; }

    }
    public class Subjects
    {
        public int SubId { get; set; }
        public string SubjectName { get; set; }
    }
}
