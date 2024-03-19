using Employee.Business;
using MediatR;

namespace Employee.Business.Commands
{
    public class CreateEmployeeCommand :IRequest<Models.Employee>
    {
        public string Name{get;set;}

        public string Age{get;set;}

        public string EmailAddress{get;set;}

        public string PhoneNumber{get;set;}

        public CreateEmployeeCommand(string name, string age, string emailAddress, string phoneNumber)
        {            
            Name = name;
            Age = age;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }

    }
}