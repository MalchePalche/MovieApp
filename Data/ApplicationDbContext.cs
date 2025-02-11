using IMDB_Clone_Web_App.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace IMDB_Clone_Web_App.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        // Add your DbSets (tables) here later
    }
}


