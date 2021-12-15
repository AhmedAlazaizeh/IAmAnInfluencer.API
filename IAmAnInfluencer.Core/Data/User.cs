using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IAmAnInfluencer.Core.Data
{
    public class User
    {
        [Key]
        public int userID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        public float salary { get; set; }
        public DateTime employmentDate { get; set; }
        public int roleID { get; set; }
        [ForeignKey("roleID")]
        public virtual Role Role { get; set; }

        public ICollection<DeductionEmployee> deductionEmployees { get; set; }
        public ICollection<BankAccount> bankAccounts { get; set; }
        public ICollection<Favorite> favorites { get; set; }
        public ICollection<Feedback> feedbacks { get; set; }
        public ICollection<IAmAnInfluncer> iamAnInfluncers { get; set; }
        public ICollection<Order> orders { get; set; }
        public ICollection<Product> products { get; set; }
    }
}
