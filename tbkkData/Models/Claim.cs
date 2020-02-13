using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Claim
    {
        [Key]
        public int ClaimID { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateClaim { get; set; }
        
        public string Status { get; set; }

        [ForeignKey("Complain")]
        public int ComplainID { get; set; }
        public Complain Complain { get; set; }

    }
}
