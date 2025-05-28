using Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repositories
{
    public interface IUserService
    {
        Task<User> AuthenticateWithGoogleAsync(string idToken);
        Task<User> GetByPasswordAsync(string password);
        Task<User> addAsync(User userDto);
        Task<List< User>> GetAllAsync();
        Task<List<Student>> GetAllStudentsAsync();

    }
}
