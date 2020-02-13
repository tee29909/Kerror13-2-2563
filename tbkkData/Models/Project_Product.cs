using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Project_Product
    {
        [Key]
        public int ProjectProductID { get; set; }

        [Display(Name = "Quantity")]
        public int Qty { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public  Product Product { get; set; }

        [ForeignKey("Project")]
        public int ProjectID { get; set; }
        public  Project Project { get; set; }
       

    }
}
