using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
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

        public List<allFeedbackDTOResult> getAllFeedback()
        {
            return feedbackRepository.getAllFeedback();
        }

        public bool updateFeedback(Feedback feedback)
        {
            return feedbackRepository.updateFeedback(feedback);
        }

        public List<approvedFeedbackDTOResult> approvedFeedback()
        {
            return feedbackRepository.approvedFeedback();
        }

        public object countOfFeedback()
        {
            return feedbackRepository.countOfFeedback();
        }

        public bool approveFeedback(int ID)
        {
            return feedbackRepository.approveFeedback(ID);
        }

        public bool disapproveFeedback(int ID)
        {
            return feedbackRepository.disapproveFeedback(ID);
        }
    }
}
