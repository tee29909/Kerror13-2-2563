using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public double CostGoal { get; set; }
        public string Status { get; set; }

        [DataType(DataType.Date)]

        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]

        public DateTime EndDate { get; set; }


        [ForeignKey("Employee")]
        [Display(Name = "Name Employee")]
        public int EmployeeID { get; set; }
        public  Employee Employee { get; set; }
        
    }
}
