using Employee.Business.Models;
using MediatR;

namespace Employee.Business.Queries
{
    public class GetEmployeeQuery:IRequest<EmployeeReadModel>
    {
        public int Id { get; set; }
    }
}