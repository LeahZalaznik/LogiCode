using Core.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IUserRepository
    {
        Task<User> AuthenticateWithGoogleAsync(string idToken);
        Task<User> GetByGoogleIdAsync(string googleId);
        Task<User> AddAsync(User user);
        Task<User> GetByPasswordAsync(string password);
        Task<User> UpdateAsync(User user);
        Task<User> DeleteAsync(string idToken);
        Task<List<User>> GetAllAsync();
        Task<List<Student>> GetAllStudentsAsync();


    }
}
