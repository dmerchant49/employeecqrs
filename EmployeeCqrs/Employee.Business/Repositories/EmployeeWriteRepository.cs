using Employee.Business.Database;

namespace Employee.Business.Repositories
{
    public class EmployeeWriteRepository : IWriteRepository
    {
        private readonly EmployeeWriteContext _context;

        public EmployeeWriteRepository(EmployeeWriteContext context)
        {
            _context=context;
        }

        public async Task<Models.Employee> AddEmployeeAsync(Models.Employee employee)
        {
            var result = _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteEmployeeAsync(int id)
        {
            var filteredData = _context.Employees.Where(x => x.Id == id).FirstOrDefault();
            _context.Employees.Remove(filteredData);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateEmployeeAsync(Models.Employee employee)
        {
            _context.Employees.Update(employee);
            return await _context.SaveChangesAsync();
        }
    }
}