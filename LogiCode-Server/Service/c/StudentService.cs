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
using UserDto = Core.DTO.User;
namespace Service.c
{
    public class StudentService: IStudentService
    {
        private readonly IStudentRepository _repository;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        public StudentService(IStudentRepository repository,IMapper mapper,IUserService userService)
        {
            _mapper = mapper;
            _repository = repository;
            _userService=userService;
        }
        public async Task<UserDto> AuthenticateWithGoogleAsync(string idToken)
        {
           return await _userService.AuthenticateWithGoogleAsync(idToken);  
        }
        public async Task<UserDto> GetByPasswordAsync(string password)
        {
            return await _userService.GetByPasswordAsync(password);

        }
  
    }
}
