using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Repositories;
using Student = Core.DAO.Student;
using CourseDto = Core.DTO.Course;
using AutoMapper;
using Core.DTO;

namespace Service.c
{
    public class CourseService: ICourseService
    {
        
        private readonly ICourseService _courseRepository;
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public CourseService(ICourseService repository, IStudentService studentService, IMapper mapper)
        {
            _courseRepository = repository;
            _studentService = studentService;
            _mapper = mapper;
        }

        public async Task<List<Course>> GetByUserAsync(string userId)
        {
       
         
            return await _courseRepository.GetByUserAsync(userId); 
          
        }
         


    }
}
