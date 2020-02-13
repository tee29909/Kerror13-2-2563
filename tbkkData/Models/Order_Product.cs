using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Order_Product
    {
        [Key]
        public int Order_ProductID { get; set; }
        public int Qty { get; set; }
        //public double Price { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public  Product Product { get; set; }
       
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public  Order Order { get; set; }
      
    }
}
