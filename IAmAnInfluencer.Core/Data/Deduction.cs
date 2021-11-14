using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IAmAnInfluencer.Core.Data
{
    public class Deduction
    {
        [Key]
        public int deductionID { get; set; }
        public string deductionTitle { get; set; }
        public float deductionValue { get; set; }
        public ICollection<DeductionEmployee> deductionEmployees { get; set; }
    }
}
