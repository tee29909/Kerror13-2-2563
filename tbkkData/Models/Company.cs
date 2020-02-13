using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        public String CompanyName { get; set; }
        public String Category { get; set; }
    }
}
