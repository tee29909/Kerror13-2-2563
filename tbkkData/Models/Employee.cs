using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        
        public string Status { get; set; }
        public double Salary { get; set; }
        public string Image { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date_of_employment { get; set; }

        [ForeignKey("Company")]
        public int CompanyID { get; set; }
        public Company Company { get; set; }

        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public  Department Department { get; set; }
       
        [ForeignKey("EmployeeType")]
        public int EmployeeTypeID { get; set; }
        public  EmployeeType EmployeeType { get; set; }
      
        [ForeignKey("Position")]
        public int PositionID { get; set; }
        public  Position Position { get; set; }


        
        public string Gender { get; set; }

    }
}
