using Microsoft.EntityFrameworkCore;

namespace MovieReviewsMVC.Models
{
    public class MovieReviewsDbContext : DbContext
    {
        public MovieReviewsDbContext(DbContextOptions<MovieReviewsDbContext> options) : base(options) {}

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Review> Reviews { get; set; }
    }
}
