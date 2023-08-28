using CourseManagment.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesManagment.DAL.Context
{
    public class ApplicationContext:IdentityDbContext
    {
        public ApplicationContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<courseLesson> CourseLessons { get; set; }
        public DbSet<Trainner> Trainners { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Admin> Admin { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=DESKTOP-NUL5HHO\\SQLEXPRESS;DataBase=CoursesManagmentDB;Trusted_Connection=true;multipleActiveResultSets=true; ");
        //}
    }
}
