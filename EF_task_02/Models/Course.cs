using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    internal class Course
    {
        public int CourseId  { get; set; }
        public string Name { get; set; }
        public string Descreption { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public List<Student> Students { get; set; }
        public List<Resource>  Resources { get; set; }
        public List<Homework>  HomeworkSubmissions { get; set; }


    }
}

//CourseId
//o Name (up to 80 characters, unicode)
//o Description (unicode, not required)
//o StartDate
//o EndDate
//o Price