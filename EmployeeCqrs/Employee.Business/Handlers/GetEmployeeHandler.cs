using Employee.Business.Models;
using Employee.Business.Queries;
using Employee.Business.Repositories;
using MediatR;

namespace Employee.Business.Handlers
{
    public class GetEmployeeHandler : IRequestHandler<GetEmployeeQuery,EmployeeReadModel>
    {
        private readonly IReadRepository _repository;

        public GetEmployeeHandler(IReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<EmployeeReadModel> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetEmployeeByIdAsync(request.Id);
        }
    }
}