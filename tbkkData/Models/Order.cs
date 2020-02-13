using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        
        [DataType(DataType.Date)]
        public DateTime OrDate { get; set; }

        
        [DataType(DataType.Date)]

        public DateTime ShippedDate { get; set; }

        public string Invoice { get; set; }

        public string Status { get; set; }


        public double Total { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public  Customer Customer { get; set; }
       
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public  Employee Employee { get; set; }
        
    }
}
