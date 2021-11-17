using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Repository;
using IAmAnInfluencer.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace IAmAnInfluencer.Infra.Service
{
    public class FeedbackService: IFeedbackService
    {
        private readonly IFeedbackRepository feedbackRepository;

        public FeedbackService(IFeedbackRepository _feedbackRepository)
        {
            feedbackRepository = _feedbackRepository;
        }

        public bool addFeedback(Feedback feedback)
        {
            return feedbackRepository.addFeedback(feedback);
        }

        public bool deleteFeedback(int ID)
        {
            return feedbackRepository.deleteFeedback(ID);
        }

        public List<Feedback> getAllFeedback()
        {
            return feedbackRepository.getAllFeedback();
        }

        public bool updateFeedback(Feedback feedback)
        {
            return feedbackRepository.updateFeedback(feedback);
        }
    }
}
