using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Survey
    {
        [Key]
        public int SurveyID { get; set; }

        public string NameSurvey { get; set; }
    }
}
