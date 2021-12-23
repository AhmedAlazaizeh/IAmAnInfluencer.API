using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.DTO
{
    public class employeeListDTOResult
    {
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
        public string image { get; set; }
        public DateTime employmentDate { get; set; }
        public int roleID { get; set; }
        public string roleTitle { get; set; }
    }
}
