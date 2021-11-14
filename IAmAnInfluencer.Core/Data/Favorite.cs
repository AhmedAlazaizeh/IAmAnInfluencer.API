using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IAmAnInfluencer.Core.Data
{
    public class Favorite
    {
        [Key]
        public int favoriteID { get; set; }
        public int userID { get; set; }
        [ForeignKey("userID")]
        public virtual User User { get; set; }
        public int productID { get; set; }
        [ForeignKey("productID")]
        public virtual Product Product { get; set; }
    }
}
