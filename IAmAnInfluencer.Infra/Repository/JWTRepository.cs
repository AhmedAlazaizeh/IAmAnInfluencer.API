using Dapper;
using IAmAnInfluencer.Core.Common;
using IAmAnInfluencer.Core.DTO;
using IAmAnInfluencer.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IAmAnInfluencer.Infra.Repository
{
    public class JWTRepository: IJWTRepository
    {
        private readonly IDbContext _dbContext;

        public JWTRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public LoginDTOResult Login(LoginDTO loginDTO)
        {
            var p = new DynamicParameters();
            p.Add("@userName", loginDTO.username, dbType: DbType.String, direction: ParameterDirection.Input); ;
            p.Add("@password", loginDTO.password, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.QueryFirstOrDefault<LoginDTOResult>("Login", p, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
