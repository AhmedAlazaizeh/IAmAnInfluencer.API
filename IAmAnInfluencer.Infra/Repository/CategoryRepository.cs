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
    public class CategoryRepository
    {
        private readonly IDbContext _dbContext;

        public CategoryRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool addCategory(Category category)
        {
            var p = new DynamicParameters();
            p.Add("@categoryTitle", category.categoryTitle, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = _dbContext.Connection.ExecuteAsync("addCategory", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Category> getAllCategory()
        {
            var p = new DynamicParameters();
            IEnumerable<Category> result = _dbContext.Connection.Query<Category>("getAllCategory", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool deleteCategory(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@categoryID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("deleteCategory", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool updateCategory(Category category)
        {
            var p = new DynamicParameters();
            p.Add("@categoryID", category.categoryID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@categoryTitle", category.categoryTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("updateCategory", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
