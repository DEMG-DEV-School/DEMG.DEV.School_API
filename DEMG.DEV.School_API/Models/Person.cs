using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEMG.DEV.School_API.Models
{
    public class Person
    {
        public string _Title { get; set; }
        public string _Name { get; set; }
        public string _MiddleName { get; set; }
        public string _LastName { get; set; }
        public DateTime _Birthday { get; set; }
        public string _Phone { get; set; }
    }
}
