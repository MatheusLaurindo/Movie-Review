using Microsoft.EntityFrameworkCore;
using MoviewReview.Core.Domain.Entities;

namespace MoviewReview.Core.Database
{
    public class MoviewReviewContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors{ get; set; }
        public DbSet<Cast> Casts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Data Source=LAPTOP-ULIQ8PS9\\SQLEXPRESS;Initial Catalog=BancoMoviewReview;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cast>()
                .HasMany(x => x.)
        }

    }
}
