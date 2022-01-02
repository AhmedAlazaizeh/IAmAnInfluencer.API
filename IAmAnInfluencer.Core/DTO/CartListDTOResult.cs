using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.DTO
{
    public class CartListDTOResult
    {
        public int productID { get; set; }
        public string productTitle { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public double price { get; set; }
        public string image { get; set; }
    }
}
