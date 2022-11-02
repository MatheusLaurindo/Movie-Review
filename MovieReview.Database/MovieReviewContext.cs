using Microsoft.EntityFrameworkCore;
using MovieReview.Core.Domain.Entities;

namespace MovieReview.Database
{
    public class MovieReviewContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Screenwriter> Screenwriters { get; set; }

        public MovieReviewContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public MovieReviewContext(DbContextOptions<MovieReviewContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "Data Source=LAPTOP-ULIQ8PS9\\SQLEXPRESS;Initial Catalog=BancoMovieReview;Integrated Security=True");
            //optionsBuilder.UseSqlServer(connectionString: "Integrated Security=SSPI;" +
            //                                              "Persist Security Info=False;" +
            //                                              "Initial Catalog=MovieReviewDB;" +
            //                                              "Data Source=J-EDSON01");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

    }
}
