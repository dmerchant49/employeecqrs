using Employee.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee.Business.Database
{
    public class EmployeeReadContext:DbContext
    {
        public DbSet<EmployeeReadModel> Employees { get; set; }

        public EmployeeReadContext(DbContextOptions<EmployeeReadContext> options) : base(options)
        {
        }
    }
}