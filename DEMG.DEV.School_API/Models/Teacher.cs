using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEMG.DEV.School_API.Models
{
    public class Teacher : Person
    {
        public List<Course> _Courses { get; set; }
        public List<Student> _Students { get; set; }
    }
}
