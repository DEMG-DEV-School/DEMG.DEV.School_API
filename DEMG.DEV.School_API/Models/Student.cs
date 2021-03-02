using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEMG.DEV.School_API.Models
{
    public class Student : Person
    {
        public Course _Course { get; set; }
    }
}
