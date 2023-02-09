using Microsoft.EntityFrameworkCore;

namespace MoviesMVC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<MoviesMVC.Models.Movie> Movies { get; set; } = default!;
        public DbSet<MoviesMVC.Models.Genre> Genres { get; set; } = default!;
    }
}
