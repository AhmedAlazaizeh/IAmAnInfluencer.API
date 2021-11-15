﻿using Dapper;
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
    public class ProductRepository
    {
        private readonly IDbContext _dbContext;

        public ProductRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool addProduct(Product product)
        {
            var p = new DynamicParameters();
            p.Add("@price", product.price, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@description", product.description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@productTitle", product.productTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@addedDate", product.addedDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@soldDate", product.soldDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@image", product.image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@isAvailable", product.isAvailable, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            p.Add("@userID", product.userID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@categoryID", product.categoryID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("addProduct", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Product> getAllProduct()
        {
            var p = new DynamicParameters();
            IEnumerable<Product> result = _dbContext.Connection.Query<Product>("getAllProduct", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool deleteProduct(int ID)
        {
            var p = new DynamicParameters();
            p.Add("@productID", ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("deleteProduct", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool updateProduct(Product product)
        {
            var p = new DynamicParameters();
            p.Add("@productID", product.productID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@price", product.price, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@description", product.description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@productTitle", product.productTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@addedDate", product.addedDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@soldDate", product.soldDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@image", product.image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@isAvailable", product.isAvailable, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            p.Add("@userID", product.userID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@categoryID", product.categoryID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("updateProduct", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
