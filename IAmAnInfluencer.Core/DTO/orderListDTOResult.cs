using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.DTO
{
    public class orderListDTOResult
    {
        public DateTime orderDate { get; set; }
        public Double orderValue { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string productTitle { get; set; }
    }
}
