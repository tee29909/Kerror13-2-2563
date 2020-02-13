using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Safety
    {
        [Key]
        public int SafetyID { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateIncident { get; set; }

        public int incident { get; set; }

        public int Total_Incident { get; set; }

    }
}
