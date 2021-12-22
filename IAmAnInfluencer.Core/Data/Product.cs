using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IAmAnInfluencer.Core.Data
{
    public class Product
    {
        [Key]
        public int productID { get; set; }
        public float price { get; set; }
        public string description { get; set; }
        public string productTitle { get; set; }
        public DateTime addedDate { get; set; }
        public string image { get; set; }
        public bool isAvailable { get; set; }
        public int userID { get; set; }
        [ForeignKey("userID")]
        public virtual User User { get; set; }
        public int categoryID { get; set; }
        [ForeignKey("categoryID")]
        public virtual Category Category { get; set; }

        public ICollection<Favorite> favorites { get; set; }
        public ICollection<Order> orders { get; set; }
    }
}
