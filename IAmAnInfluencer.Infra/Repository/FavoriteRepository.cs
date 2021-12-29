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
    public class FavoriteRepository: IFavoriteRepository
    {
        private readonly IDbContext _dbContext;

        public FavoriteRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool addFavorite(Favorite favorite)
        {
            var p = new DynamicParameters();
            p.Add("@userID", favorite.userID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@productID", favorite.productID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("addFavorite", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Favorite> getAllFavorite()
        {
            var p = new DynamicParameters();
            IEnumerable<Favorite> result = _dbContext.Connection.Query<Favorite>("getAllFavorite", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool deleteFavorite(deleteFavDTO favorite)
        {
            var p = new DynamicParameters();
            p.Add("@productID", favorite.productID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@userID", favorite.userID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("deleteFavorite", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool updateFavorite(Favorite favorite)
        {
            var p = new DynamicParameters();
            p.Add("@favoriteID", favorite.favoriteID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@userID", favorite.userID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@productID", favorite.productID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("updateFavorite", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Product> favoriteList(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@userID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Product> result = _dbContext.Connection.Query<Product>("favoriteList", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public object favCount(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@userID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            object result = _dbContext.Connection.QueryFirstOrDefault("favCount", p, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
