using CQRS_Demo.Data;
using CQRS_Demo.Data.Entities;
using CQRS_Demo.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Demo.Repositories.Implementation
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApiDbContext _context;

        public StudentRepository(ApiDbContext context)
        {
            _context = context;
        }

        //[Note]: for simplicity I'm not using DTOs, but its super bad approach to use entities within services/repos/controllers as they're just to communicate with db.

        public async Task<Student> AddStudentAsync(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task<int> DeleteStudentAsync(int Id)
        {
            var result = 0;
            var student = await GetStudentByIdAsync(Id);
            if (student != null)
            {
                _context.Students.Remove(student);
                result = await _context.SaveChangesAsync();
                return result > 0 ? 1 : 0;                
            }
            return result;
        }

        public async Task<Student> GetStudentByIdAsync(int Id)
        {
            var student = await _context.Students.Where(x => x.Id == Id).FirstOrDefaultAsync();
            return student;
        }

        public async Task<List<Student>> GetStudentListAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<int> UpdateStudentAsync(Student student)
        {
            _context.Students.Update(student);
            var result = await _context.SaveChangesAsync();
            return result > 0 ? 1 : 0;

        }
    }
}
