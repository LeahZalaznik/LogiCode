using Core.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IStudentRepository
    {
        Task<Student> AuthenticateWithGoogleAsync(string idToken);
        Task<Student> GetByGoogleIdAsync(string googleId);
        Task<Student> AddAsync(Student user);
        Task<Student> GetByPasswordAsync(string password);
        Task<Student> UpdateAsync(Student user);
        Task<Student> DeleteAsync(string idToken);
        Task<List<Student>> GetAllAsync();
        Task<List<Student>> GetAllStudentsAsync();

    }
}
