using IAmAnInfluencer.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Core.Repository
{
    public interface IFeedbackRepository
    {
        public bool addFeedback(Feedback feedback);
        public List<Feedback> getAllFeedback();
        public bool deleteFeedback(int ID);
        public bool updateFeedback(Feedback feedback);
    }
}
