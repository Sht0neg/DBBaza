using Microsoft.EntityFrameworkCore;

namespace DBBaza
{
    internal class Context : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=products.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 0, CategoryId = 0, Title = "компуктер", Price = 45678 },
                new Product { Id = 1, CategoryId = 0, Title = "компуктер2", Price = 75678 },
                new Product { Id = 2, CategoryId = 1, Title = "ипхон1", Price = 445678 }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 0, Title = "Компуктеры" },
                new Category { Id = 1, Title = "Телефоны" }
            );
        }
    }
}
