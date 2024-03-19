using Employee.Business.Models;
using Employee.Business.Queries;
using Employee.Business.Repositories;
using MediatR;

namespace Employee.Business.Handlers
{
    public class GetEmployeesHandler:IRequestHandler<GetEmployeesQuery,List<EmployeeReadModel>>
    {

        private IReadRepository _repository;

        public GetEmployeesHandler(IReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<EmployeeReadModel>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetEmployeesAsync();
        }
    }
}