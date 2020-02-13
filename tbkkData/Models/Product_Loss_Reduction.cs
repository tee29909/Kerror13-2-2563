using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Product_Loss_Reduction
    {
        [Key]
        public int Product_Loss_ReductionID { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public double Limits { get; set; }
        public double Man_Hr_Per_pc { get; set; }

        [ForeignKey("type_productLooss")]
        public int type_productLoossID { get; set; }
        public type_productLooss type_productLooss { get; set; }
    }
}
