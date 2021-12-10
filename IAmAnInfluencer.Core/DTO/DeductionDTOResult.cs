using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.DTO
{
    public class DeductionDTOResult
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public double salary { get; set; }
        public double deduction { get; set; }
        public double netSalary { get; set; }
    }
}
