using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Delivery_performance
    {
        [Key]
        public int Delivery_performanceID { get; set; }
        public int Complains_Delivery { get; set; }
        public int Claim_Delivery { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateDelivery { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}
