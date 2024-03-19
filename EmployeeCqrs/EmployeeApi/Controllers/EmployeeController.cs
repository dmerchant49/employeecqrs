using Microsoft.EntityFrameworkCore.Infrastructure;

using models= Employee.Business.Models;
using Employee.Business.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Employee.Business.Commands;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("getAllEmployees")]
        public async Task<IEnumerable<models.EmployeeReadModel>> Get()
        {
            return await _mediator.Send(new GetEmployeesQuery());
        }

        [HttpGet]
        [Route("getemployee/{id:int}")]
        public async Task<models.EmployeeReadModel> Get(int id)
        {
            return await _mediator.Send(new GetEmployeeQuery(){Id=id});
        }

        [HttpPost]
        [Route("addEmployee")]
        public async Task<models.Employee> PostAsync(models.Employee employee)
        {
            var createdEmployee = await _mediator.Send(new CreateEmployeeCommand(
                employee.Name,
                employee.Age,
                employee.EmailAddress,
                employee.PhoneNumber));
            return createdEmployee;
        }
    }
}
