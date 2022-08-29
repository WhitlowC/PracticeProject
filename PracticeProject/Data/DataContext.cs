using Microsoft.EntityFrameworkCore;

namespace PracticeProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
