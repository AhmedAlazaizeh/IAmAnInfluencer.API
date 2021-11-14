using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IAmAnInfluencer.Core.Data
{
    public class BankAccount
    {
        [Key]
        public int accountID { get; set; }
        public string cardNumber { get; set; }
        public string CVV { get; set; }
        public DateTime expDate { get; set; }
        public float balance { get; set; }
        public int userID { get; set; }
        [ForeignKey("userID")]
        public virtual User User { get; set; }
    }
}
