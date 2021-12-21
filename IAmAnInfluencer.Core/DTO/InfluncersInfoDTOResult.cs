using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.DTO
{
    public class InfluncersInfoDTOResult
    {
        public int userID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public double countOfOrders { get; set; }
        public double sumOfOrders { get; set; }
        public double sumOfRevune { get; set; }
    }
}
