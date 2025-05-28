using Core.DAO;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task = Core.DAO.MyTask;
namespace Data
{
    public class TaskRepository : ITaskRepository
    {
        private readonly LogiCodeDbContext _context;
        public TaskRepository(LogiCodeDbContext context)
        {
            _context = context;
        }
        public async Task<task> AddAsync(task task)
        {
            _context.MyTasks.Add(task);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.InnerException?.Message);
            }
            return task;
        }
        public async Task<task> DeleteAsync(int id)
        {
            var t = await _context.MyTasks.FirstOrDefaultAsync(t => t.Id == id);
            if (t == null)
                return null;

            _context.MyTasks.Remove(t);
            await _context.SaveChangesAsync();
            return t;
        }
        public async Task<List<task>> GetAllAsync()
        {
            return await _context.MyTasks.ToListAsync();
        }
        public async Task<task> GetByIdAsync(int id)
        {
            return await _context. MyTasks.FirstOrDefaultAsync(t => t.Id == id);
        }
        public async Task<task> UpdateAsync(task task)
        {
            var existingTask = await _context.MyTasks.FirstOrDefaultAsync(t => t.Id == task.Id);
            if (existingTask == null)
                return null;

            existingTask.IsCompleted = task.IsCompleted;

            await _context.SaveChangesAsync();
            return existingTask;
        }
    }
}
