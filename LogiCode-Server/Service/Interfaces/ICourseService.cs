using Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ICourseService
    {
        Task<List<Course>> GetByUserAsync(string userId);
       // Task<Course> GetByIdAsync(int courseId);
    }
}
