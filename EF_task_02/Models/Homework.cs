using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    enum ContentTypes
    {
        Application, Pdf , Zip

    }
    internal class Homework
    {
        public int HomeworkId { get; set; }
        public string Content { get; set; }
        public ContentTypes ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}


//o HomeworkId
//o Content (string, linking to a file, not unicode)
//o ContentType (enum – can be Application, Pdf or Zip)
//o SubmissionTime
//o StudentId
//o CourseId