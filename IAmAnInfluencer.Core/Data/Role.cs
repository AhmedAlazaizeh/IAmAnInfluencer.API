using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IAmAnInfluencer.Core.Data
{
    public class Role
    {
        [Key]
        public int roleID { get; set; }
        public string roleTitle { get; set; }
        public ICollection<User> users { get; set; }
    }
}
