using CQRS_Demo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Demo.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
