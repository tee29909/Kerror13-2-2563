using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Type_Survey
    {
        [Key]
        public int Type_SurveyID { get; set; }
        public string TypeSurvey { get; set; }
    }
}
