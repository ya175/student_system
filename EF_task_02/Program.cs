using StudentSystem.Data;
using StudentSystem.Models;
using System.Linq.Expressions;

namespace EF_task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeedData();





        }

        public static void SeedData()
        {
            StudentSystemContext context = new StudentSystemContext();

            List<Student> students = new List<Student>(){

                new Student {Name= "Godiva",PhoneNumber= "416-1",RegisteredOn= new DateTime(3/12/2023),Birthday= new DateTime(3/12/2023), },

                new Student {Name= "Godiva1",PhoneNumber= "416-1",RegisteredOn= new DateTime(3/12/2023),Birthday= new DateTime(3/12/2023) },

                new Student {Name= "Godiva3",PhoneNumber= "416-1",RegisteredOn= new DateTime(3/12/2023),Birthday= new DateTime(3/12/2023) }
            };
            context.Students.AddRange(students);

            List<Course> courses = new List<Course>
            {

                new Course { Name ="math", Descreption="jhhhh", StartDate=new DateTime(3/12/2023), EndDate =new DateTime(3/12/2023),Price=78888 },

                new Course { Name ="math", Descreption="jhhhh", StartDate=new DateTime(3/12/2023), EndDate =new DateTime(3/12/2023),Price=78888 },

                new Course { Name ="math", Descreption="jhhhh", StartDate=new DateTime(3/12/2023), EndDate =new DateTime(3/12/2023),Price=78888 },
            };
            context.Courses.AddRange(courses);


            List<Resource> resources = new List<Resource>
            {

                new Resource{Name="hh",Url="ll",ResourceTypes=ResourceType.Document,CourseId=16},

                new Resource{Name="ee",Url="ee",ResourceTypes=ResourceType.Video,CourseId=17},

            };

            context.Resources.AddRange(resources);


            List<Homework> homeworks = new List<Homework>
            {

                new Homework{Content="con", ContentType=ContentTypes.Zip,SubmissionTime=DateTime.Now,StudentId=16,CourseId=16},
                new Homework{Content="con", ContentType=ContentTypes.Pdf,SubmissionTime=DateTime.Now,StudentId=17,CourseId=17},

            };

            context.Homeworks.AddRange(homeworks);
            context.SaveChanges();


        }


    //    public static void Data()
    //    {

    //        StudentSystemContext context = new StudentSystemContext();


    //        //Student

    //        Student student = new Student();
    //        Console.WriteLine("Enter student name :");

    //        student.Name = Console.ReadLine();

    //        Console.WriteLine("Enter Student phone : ");
    //        student.PhoneNumber = Console.ReadLine();

    //        Console.WriteLine("Enter student Birthday");
    //        student.Birthday = Convert.ToDateTime( Console.ReadLine());
            

    //        student.RegisteredOn=DateTime.Now;



    //}


    }
}

       


