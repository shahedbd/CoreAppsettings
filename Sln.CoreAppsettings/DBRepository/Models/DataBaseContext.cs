using Microsoft.EntityFrameworkCore;

namespace DBRepository.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
        public DbSet<BasicInfo> BasicInfo { get; set; }
    }
}
