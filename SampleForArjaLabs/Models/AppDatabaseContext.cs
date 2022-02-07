using Microsoft.EntityFrameworkCore;

namespace SampleForArjaLabs.Models
{
    public class AppDatabaseContext: DbContext
    {
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options) : base(options)
        {

        }
        public DbSet<Responce> Responces { get; set; }
    }
}
