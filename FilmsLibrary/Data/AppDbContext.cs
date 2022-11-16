using FilmsLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmsLibrary.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Film> films { get; set; }
    }
}
