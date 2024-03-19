namespace Employee.Business.Repositories
{
    public interface IWriteRepository
    {
        Task<Employee.Business.Models.Employee> AddEmployeeAsync(Employee.Business.Models.Employee employee);
        Task<int> UpdateEmployeeAsync(Employee.Business.Models.Employee employee);
        Task<int> DeleteEmployeeAsync(int id);
    }
}