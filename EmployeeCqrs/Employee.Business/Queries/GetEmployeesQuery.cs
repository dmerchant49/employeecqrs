using Employee.Business.Models;
using MediatR;

namespace Employee.Business.Queries
{
    public class GetEmployeesQuery:IRequest<List<EmployeeReadModel>>
    {
        
    }
}