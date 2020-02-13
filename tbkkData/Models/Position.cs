using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Position
    {
        [Key]
        public int PositionID { get; set; }
        public String PositionName { get; set; }
    }
}
