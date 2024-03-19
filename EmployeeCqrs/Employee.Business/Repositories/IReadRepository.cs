using Employee.Business.Models;

namespace Employee.Business.Repositories
{
    public interface IReadRepository
    {
        Task<EmployeeReadModel> GetEmployeeByIdAsync(int id);       

        Task<List<EmployeeReadModel>> GetEmployeesAsync();
        
    }
}