using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Complain
    {
        [Key]
        public int ComplainID { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateComplain { get; set; }

        public string Status { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public Order Order { get; set; }





    }
}
