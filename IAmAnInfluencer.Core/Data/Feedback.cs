using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IAmAnInfluencer.Core.Data
{
    public class Feedback
    {
        [Key]
        public int feedbackID { get; set; }
        public string feedbackBody { get; set; }
        public bool isApproved { get; set; }
        public int userID { get; set; }
        [ForeignKey("userID")]
        public virtual User User { get; set; }
    }
}
