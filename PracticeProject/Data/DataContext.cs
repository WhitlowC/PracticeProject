using Microsoft.EntityFrameworkCore;
using PracticeProject.Models;

namespace PracticeProject.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }  
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
