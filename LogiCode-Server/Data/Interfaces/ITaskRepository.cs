using Core.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task = Core.DAO.MyTask;
namespace Data.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<task>> GetAllAsync();
        Task<task> GetByIdAsync(int id);
        Task<task> AddAsync(task task);
        Task<task> UpdateAsync(task task);
        Task<task> DeleteAsync(int id);
    }
}
