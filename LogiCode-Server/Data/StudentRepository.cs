using Core.DAO;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class StudentRepository : IStudentRepository
    {
        private readonly LogiCodeDbContext _context;
        private readonly IUserRepository _userRepository;
        public StudentRepository(LogiCodeDbContext context, IUserRepository userRepository) 
        {
            _context = context;
            _userRepository = userRepository;
        }
        public async Task<User> GetByGoogleIdAsync(string googleId)
        {
            return await _userRepository.GetByGoogleIdAsync(googleId);
        }

        public async Task<User> AddAsync(User user)
        {
            return await _userRepository.AddAsync(user);
        }

        public Task<User> AuthenticateWithGoogleAsync(string idToken)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetByPasswordAsync(string password)
        {
            return await _userRepository.GetByPasswordAsync(password);
        }

        public Task<User> UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> DeleteAsync(string idToken)
        {
            throw new NotImplementedException();
        }
    }
}
