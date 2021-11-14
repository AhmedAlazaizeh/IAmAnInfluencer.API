using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IAmAnInfluencer.Core.Data
{
    public class IAmAnInfluncer
    {
        [Key]
        public int IAmAnInfluncerID { get; set; }
        public string aboutUs { get; set; }
        public string ourVision { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string logo { get; set; }
        public int addedBy { get; set; }
        [ForeignKey("userID")]
        public virtual User User { get; set; }
    }
}
