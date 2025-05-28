using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core;
using Core.DTO;

namespace Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DAO.User, DTO.User>().ReverseMap();
            CreateMap<DAO.Course, DTO.Course>().ReverseMap();
            CreateMap<DAO.Exercise,DTO.Exercise>().ReverseMap();
            CreateMap<DAO.Lesson, DTO.Lesson>().ReverseMap(); 
            CreateMap<DAO.Payment, DTO.Payment>().ReverseMap();
            CreateMap<DAO.StudentCourse,DTO.StudentCourse>().ReverseMap();
            CreateMap<DAO.StudentLesson, DTO.StudentLesson>().ReverseMap();
            CreateMap<DAO.Teacher, DTO.Teacher>().ReverseMap();
            CreateMap<DAO.Student, DTO.Student>().ReverseMap();
            CreateMap<DAO.MyTask, DTO.MyTask>().ReverseMap();
        }
    }
}
