using EFCoreDatabase.Migration.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDatabase.Migration
{
    public class CompanyContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=CompanyDB;Trusted_Connection=True;");
        }
    }
}
