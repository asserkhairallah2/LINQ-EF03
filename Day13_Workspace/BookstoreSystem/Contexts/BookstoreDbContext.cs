using BookstoreSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BookstoreSystem.Contexts
{
    internal class BookstoreDbContext : DbContext
    {
        #region DbSets
        //// Define a DbSet for each entity class
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        #endregion

        #region Connection Configuration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //// Use the specified connection string
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=BookstoreDB;User Id=yermux;Password=.Mode@0987@.;Trusted_Connection=False;TrustServerCertificate=True;");        }
        #endregion

        #region Fluent API Configurations
        //// Part C — Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// Configure the Book entity
            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(b => b.Title)
                      .IsRequired()
                      .HasMaxLength(150);

                entity.Property(b => b.Price)
                      .HasColumnType("decimal(8,2)");
            });

            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
