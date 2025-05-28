using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task = Core.DAO.MyTask;
using taskDto = Core.DTO.MyTask;
namespace Service.Interfaces
{
    public interface ITaskService
    {
        Task<taskDto> GetByIdAsync(int id);
        Task<List<taskDto>> GetAllAsync();
        Task<taskDto> AddAsync(taskDto taskDto);
        Task<taskDto> UpdateAsync(taskDto taskDto);
        Task<taskDto> DeleteAsync(int id);
    }
}
