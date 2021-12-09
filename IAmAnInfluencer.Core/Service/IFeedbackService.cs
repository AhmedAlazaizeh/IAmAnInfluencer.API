using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Service
{
    public interface IFeedbackService
    {
        public bool addFeedback(Feedback feedback);
        public List<Feedback> getAllFeedback();
        public bool deleteFeedback(int ID);
        public bool updateFeedback(Feedback feedback);
        public List<approvedFeedbackDTOResult> approvedFeedback();
        public object countOfFeedback();
    }
}
