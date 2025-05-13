using AutoMapper;
using Data.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.c
{
    public class StudentService:UserService , IStudentService
    {
        private readonly IStudentRepository _repository;
        private readonly IMapper _mapper;
        public StudentService(IStudentRepository repository,IMapper mapper):base(repository,mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }
    }
}
