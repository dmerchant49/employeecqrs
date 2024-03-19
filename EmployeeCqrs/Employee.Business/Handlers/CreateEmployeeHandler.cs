using Employee.Business.Commands;
using Employee.Business;
using MediatR;
using Employee.Business.Repositories;
using Employee.Business.Models;

namespace Employee.Business.Handlers
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, Models.Employee>
    {
        private readonly IWriteRepository _repository;

        public CreateEmployeeHandler(IWriteRepository repository)
        {
            _repository=repository;
        }

        public async Task<Models.Employee> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee=new Models.Employee()
            {
              Name=request.Name,
              Age=request.Age,
              EmailAddress=request.EmailAddress,
              PhoneNumber=request.PhoneNumber  
            };
            return await _repository.AddEmployeeAsync(employee);
        }
    }
}