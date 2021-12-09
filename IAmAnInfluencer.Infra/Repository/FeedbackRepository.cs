using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using IAmAnInfluencer.Core.Common;
using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Repository;
using IAmAnInfluencer.Core.DTO;

namespace IAmAnInfluencer.Infra.Repository
{
    public class FeedbackRepository: IFeedbackRepository
    {
        private readonly IDbContext _dbContext;

        public FeedbackRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool addFeedback(Feedback feedback)
        {
            var p = new DynamicParameters();
            p.Add("@feedbackBody", feedback.feedbackBody, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@isApproved", feedback.isApproved, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            p.Add("@userID", feedback.userID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("addFeedBack", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Feedback> getAllFeedback()
        {
            var p = new DynamicParameters();
            IEnumerable<Feedback> result = _dbContext.Connection.Query<Feedback>("getAllFeedBack", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool deleteFeedback(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@feedbackID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("deleteFeedBack", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool updateFeedback(Feedback feedback)
        {
            var p = new DynamicParameters();
            p.Add("@feedbackID", feedback.feedbackID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@feedbackBody", feedback.feedbackBody, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@isApproved", feedback.isApproved, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            p.Add("@userID", feedback.userID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("updateFeedBack", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<approvedFeedbackDTOResult> approvedFeedback()
        {
            var p = new DynamicParameters();
            IEnumerable<approvedFeedbackDTOResult> result = _dbContext.Connection.Query<approvedFeedbackDTOResult>("approvedFeedback", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public object countOfFeedback()
        {
            var p = new DynamicParameters();
            object result = _dbContext.Connection.QueryFirstOrDefault("countOfFeedback", p, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
