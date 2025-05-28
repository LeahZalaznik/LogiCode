using AutoMapper;
using Core.DAO;
using Core.DTO;
using Data;
using Data.Interfaces;
using Google.Apis.Auth;
using Service.Interfaces;
using Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDto = Core.DTO.Student;
using Student = Core.DAO.Student;

using UserDto = Core.DTO.User;
namespace Service.c
{
    public class StudentService: IStudentService
    {
        private readonly IStudentRepository _repository;
        private readonly IMapper _mapper;
        public StudentService(IStudentRepository repository,IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<StudentDto> addAsync(StudentDto userDto)
        {
            Student u;
            u = _mapper.Map<Student>(userDto);
            var addedStudent = await _repository.AddAsync(u);
            return _mapper.Map<StudentDto>(addedStudent);
        }
        public async Task<StudentDto> AuthenticateWithGoogleAsync(string idToken)
        {
            var payload = await GoogleJsonWebSignature.ValidateAsync(idToken);

            var existingUser = await _repository.AuthenticateWithGoogleAsync(idToken);

            if (existingUser != null)
            {

                var student = await _repository.GetByGoogleIdAsync(existingUser.Email);
                return   _mapper.Map<StudentDto>(student);
            }
            StudentDto newUser = new StudentDto();
            newUser.PotoUrl = payload.Picture;
            newUser.Email = payload.Email;
            newUser.Provider = "google";
            newUser.Name = payload.Name;
            newUser.StudentCourses = [];
            newUser.StudentLessons = [];
            newUser.StudentTasks = [];
            return await addAsync(newUser);
        }
        public async Task<StudentDto> GetByPasswordAsync(string password)
        {
            var existingUser = await _repository.GetByPasswordAsync(password);
            if (existingUser == null)
            {
                throw new ArgumentException("not found");
            }
            return _mapper.Map<StudentDto>(existingUser);

        }
        public async Task<List<StudentDto>> GetAllAsync()
        {
            var users = await _repository.GetAllAsync();
            return _mapper.Map<List<StudentDto>>(users);
        }
        public async Task<List<StudentDto>> GetAllStudentsAsync()
        {
            var students = await _repository.GetAllStudentsAsync();
            return _mapper.Map<List<StudentDto>>(students);
        }
        public async Task<StudentDto> UpdateAsync(StudentDto stud)
        {
            var student = await _repository.UpdateAsync(_mapper.Map<Student>(stud));
            return _mapper.Map<StudentDto>(student);
        }
    }
}
