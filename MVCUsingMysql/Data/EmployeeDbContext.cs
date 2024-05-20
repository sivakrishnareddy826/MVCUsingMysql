using Microsoft.EntityFrameworkCore;
using MVCUsingMysql.Models;

namespace MVCUsingMysql.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
