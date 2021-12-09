using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.DTO
{
    public class approvedFeedbackDTOResult
    {
        public int feedbackID { get; set; }
        public string feedbackBody { get; set; }
        public bool isApproved { get; set; }
        public int userID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public float salary { get; set; }
        public DateTime employmentDate { get; set; }
        public int roleID { get; set; }
    }
}
