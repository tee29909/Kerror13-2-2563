using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class type_productLooss
    {
        [Key]
        public int type_productLoossID { get; set; }

        public string Name { get; set; }

        
    }
}
