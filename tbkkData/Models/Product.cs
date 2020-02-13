using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Display(Name = "Name Product")]
        public string Name { get; set; }
        public string Status { get; set; }
        public double CostPrice { get; set; }
        public double SellingPrice { get; set; }

        [ForeignKey("Partners")]
        public int PartnersID { get; set; }
        public  Partners Partners { get; set; }
       

    }
}
