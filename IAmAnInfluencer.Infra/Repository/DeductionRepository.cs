using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using IAmAnInfluencer.Core.Common;
using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Repository;

namespace IAmAnInfluencer.Infra.Repository
{
    public class DeductionRepository
    {
        private readonly IDbContext _dbContext;

        public DeductionRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool addDeduction(Deduction deduction)
        {
            var p = new DynamicParameters();
            p.Add("@deductionTitle", deduction.deductionTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@deductionValue", deduction.deductionTitle, dbType: DbType.Double, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("addDeduction", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Deduction> getAllDeduction()
        {
            var p = new DynamicParameters();
            IEnumerable<Deduction> result = _dbContext.Connection.Query<Deduction>("getAllDeduction", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool deleteDeduction(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@deductionID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("deleteDeduction", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool updateDeduction(Deduction deduction)
        {
            var p = new DynamicParameters();
            p.Add("@deductionID", deduction.deductionID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@deductionTitle", deduction.deductionTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@deductionValue", deduction.deductionTitle, dbType: DbType.Double, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("updateDeduction", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
