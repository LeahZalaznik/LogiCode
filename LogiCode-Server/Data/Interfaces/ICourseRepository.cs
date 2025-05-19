using Core.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface ICourseRepository
    {
        Task<Course> AddAsync(Course course);
        Task<List<Course>> GetByUserAsync(string userId);
        Task<Course> UpdateAsync(Course course);
        Task<Course> GetByIdAsync(int id);
       // Task<Course> DeleteAsync(string idToken);
    }
}
