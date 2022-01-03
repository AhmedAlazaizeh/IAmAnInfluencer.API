using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.DTO
{
    public class orderListDTOResult
    {
        public int orderID { get; set; }
        public DateTime orderDate { get; set; }
        public Double orderValue { get; set; }
        public bool isDelivered { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string productTitle { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        public string phoneNumber { get; set; }
    }
}
