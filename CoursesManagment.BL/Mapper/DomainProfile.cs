using AutoMapper;
using CourseManagment.BL.Models;
using CourseManagment.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesManagment.BL.Mapper
{
    public class DomainProfile:Profile
    {
        public DomainProfile()
        {
            CreateMap<Category, CategoryVm>();
            CreateMap<CategoryVm, Category>();
            CreateMap<Course, CourseVm>();
            CreateMap<CourseVm, Course>();
            CreateMap<Trainee, TraineeVm>();
            CreateMap<TraineeVm, Trainee>();
            CreateMap<Trainner, TrainnerVm>();
            CreateMap<TrainnerVm, Trainner>();
            CreateMap<courseLesson, courseLessonVm>();
            CreateMap<courseLessonVm, courseLesson>();
        }
    }
}
