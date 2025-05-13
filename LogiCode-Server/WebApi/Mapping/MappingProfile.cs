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
            CreateMap<DAO.Course, DTO.Course>().ForMember(dest => dest.Lessons, opt => opt.MapFrom(src => src.Lessons.Select(l => l.Id)));
            CreateMap<DTO.Course, DAO.Course>().ForMember(dest => dest.Lessons, opt => opt.Ignore()); 
            CreateMap<DAO.Exercise,DTO.Exercise>().ReverseMap();
            CreateMap<DAO.Lesson, DAO.Lesson>().ReverseMap(); 
            CreateMap<DAO.Payment, DAO.Payment>().ReverseMap();
            CreateMap<DAO.StudentCourse,DAO.StudentCourse>().ReverseMap();
            CreateMap<DAO.StudentLesson,DAO.StudentLesson>().ReverseMap();
            CreateMap<DAO.Teacher,DTO.Teacher>().ReverseMap();
            CreateMap<DTO.Teacher, DAO.Teacher>().ReverseMap();
            CreateMap<DAO.Student, DTO.Student>().ReverseMap();
            CreateMap<DTO.Student, DAO.Student>().ReverseMap();
            CreateMap<DAO.Student, DTO.Student>().ReverseMap();
            CreateMap<DTO.Student, DAO.Student>().ReverseMap();
        }
    }
}
