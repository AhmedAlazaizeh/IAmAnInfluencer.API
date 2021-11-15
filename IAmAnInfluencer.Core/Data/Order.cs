using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IAmAnInfluencer.Core.Data
{
    public class Order
    {
        [Key]
        public int orderID { get; set; }
        public DateTime orderDate { get; set; }
        public bool isOrder { get; set; }
        public float orderValue { get; set; }
        public int userID { get; set; }
        [ForeignKey("userID")]
        public virtual User User { get; set; }
        public int productID { get; set; }
        [ForeignKey("productID")]
        public virtual Product Product { get; set; }
    }
}
