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
    public class DeductionEmployeeRepository: IDeductionEmployeeRepository
    {
        private readonly IDbContext _dbContext;

        public DeductionEmployeeRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool addDeductionEmployee(DeductionEmployee deductionEmployee)
        {
            var p = new DynamicParameters();
            p.Add("@deductionID", deductionEmployee.deductionID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@employeeID", deductionEmployee.employeeID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("addDeductionEmployee", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<DeductionEmployee> getAllDeductionEmployee()
        {
            var p = new DynamicParameters();
            IEnumerable<DeductionEmployee> result = _dbContext.Connection.Query<DeductionEmployee>("getAllDeductionEmployee", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool deleteDeductionEmployee(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@deductionEmployeeID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("deleteDeductionEmployee", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool updateDeductionEmployee(DeductionEmployee deductionEmployee)
        {
            var p = new DynamicParameters();
            p.Add("@deductionEmployeeID", deductionEmployee.deductionEmployeeID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@deductionID", deductionEmployee.deductionID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@employeeID", deductionEmployee.employeeID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("updateDeductionEmployee", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
