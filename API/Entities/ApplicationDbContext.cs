using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Author>()
                .HasMany(p => p.Books)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}