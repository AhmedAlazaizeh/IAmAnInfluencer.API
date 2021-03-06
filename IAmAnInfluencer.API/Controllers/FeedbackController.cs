using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
using IAmAnInfluencer.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAmAnInfluencer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService feedbackService;
        public FeedbackController(IFeedbackService _feedbackService)
        {
            feedbackService = _feedbackService;
        }

        [HttpPost]
        [Route("Add")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool addFeedback(Feedback feedback)
        {
            return feedbackService.addFeedback(feedback);
        }

        [HttpDelete]
        [Route("Delete/{ID}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool deleteFeedback(int ID)
        {
            return feedbackService.deleteFeedback(ID);
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(typeof(List<allFeedbackDTOResult>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<allFeedbackDTOResult> getAllFeedback()
        {
            return feedbackService.getAllFeedback();
        }

        [HttpPut]
        [Route("Update")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool updateFeedback(Feedback feedback)
        {
            return feedbackService.updateFeedback(feedback);
        }

        [HttpGet]
        [Route("approvedFeedback")]
        [ProducesResponseType(typeof(List<approvedFeedbackDTOResult>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<approvedFeedbackDTOResult> approvedFeedback()
        {
            return feedbackService.approvedFeedback();
        }

        [HttpGet]
        [Route("countOfFeedback")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public object countOfFeedback()
        {
            return feedbackService.countOfFeedback();
        }

        [HttpGet]
        [Route("Approve/{ID}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool approveFeedback(int ID)
        {
            return feedbackService.approveFeedback(ID);
        }

        [HttpGet]
        [Route("Disapprove/{ID}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool disapproveFeedback(int ID)
        {
            return feedbackService.disapproveFeedback(ID);
        }
    }
}
