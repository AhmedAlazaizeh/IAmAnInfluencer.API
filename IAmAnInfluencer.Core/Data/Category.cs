using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IAmAnInfluencer.Core.Data
{
    public class Category
    {
        [Key]
        public int categoryID { get; set; }
        public string categoryTitle { get; set; }
        public ICollection<Product> products { get; set; }
    }
}
