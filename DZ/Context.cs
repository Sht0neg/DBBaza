using Microsoft.EntityFrameworkCore;

namespace DZ
{
    internal class Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=employees.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 0, Age = 21, FirstName = "dddd", SecondName = "DDDD", Position = "menedger", Married = true, HadChildren = false},
                new Employee { Id = 1, Age = 31, FirstName = "ssss", SecondName = "SSSS", Position = "menedger", Married = true, HadChildren = true }
                );
        }
    }
}




