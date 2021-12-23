using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.DTO
{
    public class getAProductDTOResult
    {
        public int productID { get; set; }
        public float price { get; set; }
        public string description { get; set; }
        public string productTitle { get; set; }
        public DateTime addedDate { get; set; }
        public string image { get; set; }
        public bool isAvailable { get; set; }
        public int userID { get; set; }
        public int categoryID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
    }
}
