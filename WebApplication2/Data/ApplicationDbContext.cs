using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees1 { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ABU-SHQAIR\\SQLEXPRESS;Database=FS8_MVC1;trusted_Connection=True;TrustServerCertificate=true;");
        }
    }
}
