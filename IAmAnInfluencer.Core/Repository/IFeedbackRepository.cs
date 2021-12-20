using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Repository
{
    public interface IFeedbackRepository
    {
        public bool addFeedback(Feedback feedback);
        public List<allFeedbackDTOResult> getAllFeedback();
        public bool deleteFeedback(int ID);
        public bool updateFeedback(Feedback feedback);
        public List<approvedFeedbackDTOResult> approvedFeedback();
        public object countOfFeedback();
        public bool approveFeedback(int ID);
        public bool disapproveFeedback(int ID);
    }
}
