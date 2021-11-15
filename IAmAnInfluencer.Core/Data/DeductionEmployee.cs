using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IAmAnInfluencer.Core.Data
{
    public class DeductionEmployee
    {
        [Key]
        public int deductionEmployeeID { get; set; }

        public int deductionID { get; set; }
        [ForeignKey("deductionID")]
        public virtual Deduction Deduction { get; set; }

        public int employeeID { get; set; }
        [ForeignKey("userID")]
        public virtual User User { get; set; }

    }
}
