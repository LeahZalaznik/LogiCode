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
            User u = await _repository.AddAsync(_mapper.Map<User>(userDto));
            return _mapper.Map<UserDto>(u);
        }

        public async Task<UserDto> AuthenticateWithGoogleAsync(string idToken)
        {
            var payload = await GoogleJsonWebSignature.ValidateAsync(idToken);

            var existingUser = await _repository.GetByGoogleIdAsync(payload.Subject);

            if (existingUser != null)
            {
                return  _mapper.Map<UserDto>(existingUser);
            }

            var newUser = new User
            {
                GoogleId = payload.Subject,
                Name = payload.Name,
                Email = payload.Email,
                PotoUrl = payload.Picture
            };

            var addedUser = await _repository.AddAsync(newUser);
            return _mapper.Map<UserDto>(addedUser);
        }
        public async Task<UserDto> GetByPasswordAsync(string password)
        {
            var existingUser=await _repository.GetByPasswordAsync(password);
            if (existingUser == null)
            {
                throw new ArgumentException("not found");  
            }
            return _mapper.Map<UserDto>(existingUser);

        }

    }
}


