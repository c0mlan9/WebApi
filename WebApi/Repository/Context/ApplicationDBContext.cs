using Microsoft.EntityFrameworkCore;

using WebApi.Domain.Entities.Movie;

namespace WebApi.Repository.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> opt) : base(opt) { }

        public DbSet<Movie> Movies { get; set; }
    }
}
