using Core.DTO;
using Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IStudentService 
    {
        Task<Student> AuthenticateWithGoogleAsync(string idToken);
        Task<Student> GetByPasswordAsync(string password);
        Task<Student> addAsync(Student userDto);
        Task<List<Student>> GetAllAsync();
        Task<List<Student>> GetAllStudentsAsync();
        Task<Student> UpdateAsync(Student student);

    }
}
