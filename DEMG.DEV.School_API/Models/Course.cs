using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEMG.DEV.School_API.Models
{
    public class Course
    {
        public string _Title { get; set; }
        public string _Name { get; set; }
        public string _Description { get; set; }
        public List<Subject> _Subjects { get; set; }
    }
}
