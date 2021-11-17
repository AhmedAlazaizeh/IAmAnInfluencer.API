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
    public class RoleRepository: IRoleRepository
    {
        private readonly IDbContext _dbContext;

        public RoleRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool addRole(Role role)
        {
            var p = new DynamicParameters();
            p.Add("@roleTitle", role.roleTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("addRole", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Role> getAllRole()
        {
            var p = new DynamicParameters();
            IEnumerable<Role> result = _dbContext.Connection.Query<Role>("getAllRole", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool deleteRole(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@roleID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("deleteRole", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool updateRole(Role role)
        {
            var p = new DynamicParameters();
            p.Add("@roleID", role.roleID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@roleTitle", role.roleTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("updateRole", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
