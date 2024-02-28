using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{

    enum ResourceType
    {
        Video, Presentation, Document , Other
    }
    internal class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string   Url { get; set; }
        public ResourceType ResourceTypes { get; set; }
        public int CourseId { get; set; }
        public Course  Course{ get; set; }
    }
}


//ResourceId
//o Name (up to 50 characters, unicode)
//o Url (not unicode)
//o ResourceType (enum – can be Video, Presentation, Document or Other)
//o CourseId
