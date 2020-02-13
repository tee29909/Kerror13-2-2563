using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class EmployeeType
    {
        [Key]
        public int EmployeeTypeID { get; set; }
        public string EmployeeTypeName { get; set; }
    }
}
