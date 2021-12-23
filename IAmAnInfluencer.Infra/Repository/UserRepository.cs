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
    public class UserRepository: IUserRepository
    {
        private readonly IDbContext _dbContext;

        public UserRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool addUser(addUserDTO addUserDTO)
        {
            var p = new DynamicParameters();
            p.Add("@fName", addUserDTO.fName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@lName", addUserDTO.lName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@email", addUserDTO.email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@phoneNumber", addUserDTO.phoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@roleID", addUserDTO.roleID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@username", addUserDTO.username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@password", addUserDTO.password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@salary", addUserDTO.salary, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@longitude", addUserDTO.longitude, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@latitude", addUserDTO.latitude, dbType: DbType.String, direction: ParameterDirection.Input);
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
            p.Add("@employmentDate", user.employmentDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@longitude", user.longitude, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@latitude", user.latitude, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("updateUser", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public object countOfCustomers()
        {
            var p = new DynamicParameters();
            object result = _dbContext.Connection.QueryFirstOrDefault("countOfCustomers", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public object countOfEmployees()
        {
            var p = new DynamicParameters();
            object result = _dbContext.Connection.QueryFirstOrDefault("countOfEmployees", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public object countOfInfluncers()
        {
            var p = new DynamicParameters();
            object result = _dbContext.Connection.QueryFirstOrDefault("countOfInfluncers", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public List<User> customersList()
        {
            var p = new DynamicParameters();
            IEnumerable<User> result = _dbContext.Connection.Query<User>("customersList", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<employeeListDTOResult> employeeList()
        {
            var p = new DynamicParameters();
            IEnumerable<employeeListDTOResult> result = _dbContext.Connection.Query<employeeListDTOResult>("employeeList", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<User> influncersList()
        {
            var p = new DynamicParameters();
            IEnumerable<User> result = _dbContext.Connection.Query<User>("influncersList", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<User> getUser(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@userID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<User> result = _dbContext.Connection.Query<User>("getUser", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<User> getUserByUsername(string username)
        {
            var p = new DynamicParameters();
            p.Add("@username", username, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.Query<User>("getUserByUsername", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public int getUserIDbyUsername(string username)
        {
            var p = new DynamicParameters();
            p.Add("@username", username, dbType: DbType.String, direction: ParameterDirection.Input);
            int result = Convert.ToInt32( _dbContext.Connection.QueryFirstOrDefault("getUserIDbyUsername", p, commandType: CommandType.StoredProcedure));
            return result;
        }

        public List<DeductionDTOResult> getFinancial()
        {
            var p = new DynamicParameters();
            var result = _dbContext.Connection.Query<DeductionDTOResult>("getFinancialList", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool update(int userID, string fName, string lName, string email, string phoneNumber, string username, string password, string longitude, string latitude, DateTime employmentDate, int roleID, double salary)
        {
            var p = new DynamicParameters();
            p.Add("@userID", userID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@fName", fName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@lName", lName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@email", email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@phoneNumber", phoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@roleID", roleID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@username", username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@password", password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@salary", salary, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@employmentDate", employmentDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@longitude", longitude, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@latitude", latitude, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("updateUser", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
