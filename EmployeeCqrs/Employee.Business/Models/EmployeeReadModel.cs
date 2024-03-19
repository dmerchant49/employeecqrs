

using System.ComponentModel.DataAnnotations.Schema;

namespace Employee.Business.Models
{
    [Table("Employee")]
    public class EmployeeReadModel
    {
        public int Id{get;set;}

        public string Name{get;set;}

        public string EmailAddress{get;set;}

        public string PhoneNumber{get;set;}
    }
}