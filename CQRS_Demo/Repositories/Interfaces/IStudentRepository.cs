using CQRS_Demo.Data.Entities;

namespace CQRS_Demo.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        public Task<List<Student>> GetStudentListAsync();
        public Task<Student> GetStudentByIdAsync(int Id);
        public Task<Student> AddStudentAsync(Student student);
        public Task<int> UpdateStudentAsync(Student student);
        public Task<int> DeleteStudentAsync(int Id);
    }
}
