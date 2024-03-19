using Employee.Business.Database;
using Employee.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee.Business.Repositories
{
    public class EmployeeReadRepository : IReadRepository
    {
        private readonly EmployeeReadContext _context;

        public EmployeeReadRepository(EmployeeReadContext context)
        {
            _context = context;
        }

        public async Task<EmployeeReadModel> GetEmployeeByIdAsync(int id)
        {
            return await _context.Employees.Where(emp=>emp.Id==id).FirstOrDefaultAsync();
        }

        public async Task<List<EmployeeReadModel>> GetEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}