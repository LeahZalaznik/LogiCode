using Core.DAO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UserRepository : IUserRepository
    {
        private readonly LogiCodeDbContext _context;

        public UserRepository(LogiCodeDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetByGoogleIdAsync(string googleId)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.GoogleId == googleId);
        }

        public async Task<User> AddAsync(User user)
        {
            _context.Users.Add(user);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.InnerException?.Message);
            }
            return user;
        }

        public Task<User> AuthenticateWithGoogleAsync(string idToken)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetByPasswordAsync(string password)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == password);
        }
        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }
        public Task<User> UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> DeleteAsync(string idToken)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _context.Students
                .ToListAsync();
        }

    }

}
