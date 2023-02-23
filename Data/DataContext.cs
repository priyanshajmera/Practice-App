using Microsoft.EntityFrameworkCore;
using PracticeApi.Entities;

namespace PracticeApi.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; }

    }
}
