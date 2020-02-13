using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SurveyOperators
    {
        [Key]
        public int SurveyOperatorsID { get; set; }
        

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public int SurveyCount { get; set; }

        [ForeignKey("Type_Survey")]
        public int Type_SurveyID { get; set; }
        public Type_Survey Type_Survey { get; set; }

        [ForeignKey("Survey")]
        public int SurveyID { get; set; }
        public Survey Survey { get; set; }
    }
}
