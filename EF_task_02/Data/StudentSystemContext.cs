using Microsoft.EntityFrameworkCore;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data
{
    internal class StudentSystemContext:DbContext
    {
        public DbSet<Course>Courses  { get; set; }
        public DbSet<Homework>Homeworks  { get; set; }
        public DbSet<Resource> Resources  { get; set; }
        public DbSet<Student>Students  { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=YASSMINE\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Property(e=>e.Name).HasMaxLength(100).IsUnicode(true);
            modelBuilder.Entity<Student>().Property(e => e.PhoneNumber).HasMaxLength(10).IsUnicode(false).IsRequired(false);
            //modelBuilder.Entity<Student>().Property(e=>e.Birthday).IsRequired(false);

            modelBuilder.Entity<Course>().Property(e => e.Name).HasMaxLength(80).IsUnicode(true);
            modelBuilder.Entity<Course>().Property(e => e.Descreption).IsRequired(false).IsUnicode(true);

            modelBuilder.Entity<Resource>().Property(e => e.Name).HasMaxLength(50).IsUnicode(true);
            modelBuilder.Entity<Resource>().Property(e => e.Url).IsUnicode(false);

            modelBuilder.Entity<Homework>().Property(e => e.Content).IsUnicode(false);//


            //relationships

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Courses)
                .WithMany(e => e.Students);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.HomeworkSubmisssions)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Resources)
                .WithOne(e => e.Course)
                .HasForeignKey(e => e.CourseId);


            modelBuilder.Entity<Course>()
                .HasMany(e => e.HomeworkSubmissions)
                .WithOne(e => e.Course)
                .HasForeignKey(e => e.CourseId);
        }

    }
}