using Core.DAO;
using Core.DTO;
using Data;
using Google.Apis.Auth;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata;
using Service.Repositories;
using System.Threading.Tasks;
using User = Core.DAO.User;
using UserDto = Core.DTO.User;
using Student = Core.DAO.Student;
using StudentDto = Core.DTO.Student;

namespace Service.c
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UserDto> addAsync(UserDto userDto)
        {
            User u;

            u = _mapper.Map<User>(userDto);


            var addedUser = await _repository.AddAsync(u);
            return _mapper.Map<UserDto>(addedUser);
        }

        public async Task<UserDto> AuthenticateWithGoogleAsync(string idToken)
        {
            var payload = await GoogleJsonWebSignature.ValidateAsync(idToken);

            var existingUser = await _repository.GetByGoogleIdAsync(payload.Subject);

            if (existingUser != null)
            {
                return _mapper.Map<UserDto>(existingUser);
            }
            User newUser = new User();
            newUser.PotoUrl = payload.Picture;
            newUser.Email = payload.Email;
            newUser.GoogleId = payload.Subject;
            newUser.Name = payload.Name;


            var addedUser = await _repository.AddAsync(newUser);
            return _mapper.Map<UserDto>(addedUser);
        }

        public async Task<UserDto> GetByPasswordAsync(string password)
        {
            var existingUser = await _repository.GetByPasswordAsync(password);
            if (existingUser == null)
            {
                throw new ArgumentException("not found");
            }
            return _mapper.Map<UserDto>(existingUser);

        }
        public async Task<List<UserDto>> GetAllAsync()
        {
            var users = await _repository.GetAllAsync();
            return _mapper.Map<List<UserDto>>(users);
        }
        public async Task<List<StudentDto>> GetAllStudentsAsync()
        {
            var students = await _repository.GetAllStudentsAsync();
            return _mapper.Map<List<StudentDto>>(students);
        }
    }
}


