using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core;

namespace Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DAO.User, DTO.User>().ReverseMap();
            CreateMap<DAO.Course, DTO.Course>().ForMember(dest => dest.LessonIds, opt => opt.MapFrom(src => src.Lessons.Select(l => l.Id)));
            CreateMap<DTO.Course, DAO.Course>().ForMember(dest => dest.Lessons, opt => opt.Ignore()); 
            CreateMap<DAO.Exercise,DTO.Exercise>().ReverseMap();
            CreateMap<DAO.Lesson, DAO.Lesson>().ReverseMap(); 
            CreateMap<DAO.Payment, DAO.Payment>().ReverseMap();
            CreateMap<DAO.StudentCourse,DAO.StudentCourse>().ReverseMap();
            CreateMap<DAO.StudentLesson,DAO.StudentLesson>().ReverseMap();
            CreateMap<DAO.Teacher,DTO.Teacher>().ForMember(dest => dest.CourseIds, opt => opt.MapFrom(src => src.Courses.Select(l => l.Id)));
            CreateMap<DTO.Teacher, DAO.Teacher>().ForMember(dest => dest.Courses, opt => opt.Ignore());
            CreateMap<DAO.Student, DTO.Student>().ForMember(dest => dest.StudentLessonIds, opt => opt.MapFrom(src => src.StudentLessons.Select(l => l.Id)));
            CreateMap<DTO.Student, DAO.Student>().ForMember(dest => dest.StudentLessons, opt => opt.Ignore());
            CreateMap<DAO.Student, DTO.Student>().ForMember(dest => dest.StudentCourseIds, opt => opt.MapFrom(src => src.StudentCourses.Select(l => l.Id)));
            CreateMap<DTO.Student, DAO.Student>().ForMember(dest => dest.StudentCourses, opt => opt.Ignore());
        }
    }
}
