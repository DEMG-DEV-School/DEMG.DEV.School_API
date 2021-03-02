using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEMG.DEV.School_API.Data
{
    public class Teacher
    {
        public string _Title { get; set; }
        public string _Name { get; set; }
        public string _LastName { get; set; }
        public DateTime _Birthday { get; set; }
        public List<Course> _Courses { get; set; }
        public List<Student> _Students { get; set; }
    }
}
