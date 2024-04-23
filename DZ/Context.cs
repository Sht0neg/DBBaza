using Microsoft.EntityFrameworkCore;

namespace DZ
{
    internal class Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Company> Companies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=employees.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 0, CompanyId = 0 , Age = 21, FirstName = "dddd", SecondName = "DDDD", Position = "menedger", Married = true, HadChildren = false},
                new Employee { EmployeeId = 1, CompanyId = 0, Age = 31, FirstName = "ssss", SecondName = "SSSS", Position = "menedger", Married = true, HadChildren = true }
                );
            modelBuilder.Entity<Company>().HasData(
                new Company {CompanyId = 0, Data = "22.02.2002", Name = "GGG", Specialisation = "Tov" }
                );
        }
    }
}




