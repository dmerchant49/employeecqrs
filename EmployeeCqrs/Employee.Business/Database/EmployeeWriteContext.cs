using Employee.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee.Business.Database
{
    public class EmployeeWriteContext : DbContext
    {
        public DbSet<Employee.Business.Models.Employee> Employees { get; set; }

        public EmployeeWriteContext(DbContextOptions<EmployeeWriteContext> options) : base(options)
        {
        }
    }
}