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
    public class UserRepository: IUserRepository
    {
        private readonly IDbContext _dbContext;

        public UserRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool addUser(User user)
        {
            var p = new DynamicParameters();
            p.Add("@fName", user.fName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@lName", user.lName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@email", user.email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@phoneNumber", user.phoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@roleID", user.roleID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@username", user.username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@password", user.password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@salary", user.salary, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@employmentDate", user.employmentDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("addUser", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<User> getAllUser()
        {
            var p = new DynamicParameters();
            IEnumerable<User> result = _dbContext.Connection.Query<User>("getAllUser", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool deleteUser(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@userID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("deleteUser", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool updateUser(User user)
        {
            var p = new DynamicParameters();
            p.Add("@userID", user.userID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@fName", user.fName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@lName", user.lName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@email", user.email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@phoneNumber", user.phoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@roleID", user.roleID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@username", user.username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@password", user.password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@salary", user.salary, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@employmentDate", user.employmentDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("updateUser", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
