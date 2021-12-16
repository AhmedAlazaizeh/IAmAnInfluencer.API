using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.DTO
{
    public class addOrderDTO
    {
        public int orderID { get; set; }
        public bool isOrder { get; set; }
        public bool isDelivered { get; set; }
        public float orderValue { get; set; }
        public int userID { get; set; }
        public int productID { get; set; }
    }
}
