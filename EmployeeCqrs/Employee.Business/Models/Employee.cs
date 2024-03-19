using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee.Business.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{get;set;}

        public string Name{get;set;}

        public string Age{get;set;}

        public string EmailAddress{get;set;}

        public string PhoneNumber{get;set;}
    }
}