using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.DTO
{
    public class allFeedbackDTOResult
    {
        public int feedbackID { get; set; }
        public string feedbackBody { get; set; }
        public bool isApproved { get; set; }
        public int userID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
    }
}
