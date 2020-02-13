using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Rival_Product
    {
        [Key]
        public int RivProductID { get; set; }
        

        [DataType(DataType.Date)]   
        public DateTime RivDate { get; set; }

        public double Price { get; set; }

        [ForeignKey("Product")]
         public int ProductID { get; set; }
        public  Product Product { get; set; }
        [ForeignKey("Rival")]
        public int RivalID { get; set; }
        public  Rival Rival { get; set; }
       
    }
}
