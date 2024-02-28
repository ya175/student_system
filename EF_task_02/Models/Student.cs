using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    internal class Student
    {

        public int StudentId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime Birthday { get; set; }

        public List<Course> Courses { get; set; }
        public List<Homework> HomeworkSubmisssions { get; set; }

    }
}


//StudentId
//o Name (up to 100 characters, unicode)
//o PhoneNumber (exactly 10 characters, not unicode, not required)
//o RegisteredOn (DateTime)
//o Birthday (not required)
