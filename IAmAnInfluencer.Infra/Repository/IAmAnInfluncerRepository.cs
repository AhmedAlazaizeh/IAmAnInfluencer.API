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
    public class IAmAnInfluncerRepository
    {
        private readonly IDbContext _dbContext;

        public IAmAnInfluncerRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool addIAmAnInfluncer(IAmAnInfluncer iamAnInfluncer)
        {
            var p = new DynamicParameters();
            p.Add("@aboutUs", iamAnInfluncer.aboutUs, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ourVision", iamAnInfluncer.ourVision, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@email", iamAnInfluncer.email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@phoneNumber", iamAnInfluncer.phoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@address", iamAnInfluncer.address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@logo", iamAnInfluncer.logo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@addedBy", iamAnInfluncer.addedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("addIAmAnInfluncer", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<IAmAnInfluncer> getAllIAmAnInfluncer()
        {
            var p = new DynamicParameters();
            IEnumerable<IAmAnInfluncer> result = _dbContext.Connection.Query<IAmAnInfluncer>("getAllIAmAnInfluncer", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool deleteIAmAnInfluncer(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@IAmAnInfluncerID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("deleteIAmAnInfluncer", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool updateIAmAnInfluncer(IAmAnInfluncer iamAnInfluncer)
        {
            var p = new DynamicParameters();
            p.Add("@IAmAnInfluncerID", iamAnInfluncer.IAmAnInfluncerID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@aboutUs", iamAnInfluncer.aboutUs, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ourVision", iamAnInfluncer.ourVision, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@email", iamAnInfluncer.email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@phoneNumber", iamAnInfluncer.phoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@address", iamAnInfluncer.address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@logo", iamAnInfluncer.logo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@addedBy", iamAnInfluncer.addedBy, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("updateIAmAnInfluncer", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
