using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.DTO
{
    public class AddProductDTO
    {
        public int productID { get; set; }
        public float price { get; set; }
        public string description { get; set; }
        public string productTitle { get; set; }
        public string image { get; set; }
        public bool isAvailable { get; set; }
        public int userID { get; set; }
        public int categoryID { get; set; }
    }
}
