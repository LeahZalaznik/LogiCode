using Core.DAO;
using Data.Interfaces;
using Google.Apis.Auth;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class StudentRepository : IStudentRepository
    {
        private readonly LogiCodeDbContext _context;
        public StudentRepository(LogiCodeDbContext context)
        {
            _context = context;
        }
        public async Task<Student> GetByGoogleIdAsync(string email)
        {
            Student s= await _context.Students.Include(s=>s.StudentTasks).FirstOrDefaultAsync(u => u.Email == email);
            return s;
        }
        public async Task<Student> AddAsync(Student user)
        {
            _context.Students.Add(user);
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

        public async Task<Student> AuthenticateWithGoogleAsync(string idToken)
{
             var payload = await GoogleJsonWebSignature.ValidateAsync(idToken);
             return await _context.Students.FirstOrDefaultAsync(s => s.Email == payload.Email);
}

        public async Task<Student> GetByPasswordAsync(string password)
        {
            return await _context.Students.Include(s=>s.StudentTasks).Include(s=>s.StudentCourses).Include(s=>s.StudentLessons).FirstOrDefaultAsync(u => u.Email == password);
        }
    
        public async Task<Student> UpdateAsync(Student user)
        {
            var existingStudent = await _context.Students.FirstOrDefaultAsync(t => t.Id == user.Id);
            if (existingStudent == null)
                return null;
            existingStudent.Name = user.Name;
            await _context.SaveChangesAsync();
            return existingStudent;
        }

        public Task<Student> DeleteAsync(string idToken)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _context.Students.Include("StudentTasks")
                .ToListAsync();
        }

       public async  Task<List<Student>> GetAllAsync()
        {
            return await _context.Students.ToListAsync();
        }
    }
}
